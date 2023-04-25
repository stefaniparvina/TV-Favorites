using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace TV_Favorites
{
    /// <summary>
    /// Interaction logic for Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Window
    {
        public Sign_Up()
        {
            InitializeComponent();
            UserLoginState loginState = (UserLoginState)Properties.Settings.Default.UserLoginState;
            if (loginState != null && loginState.IsLoggedIn)
            {
                Main_Page main_Page = new Main_Page();
                main_Page.Show();
                this.Close();
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidField(string field)
        {
            return !string.IsNullOrWhiteSpace(field);
        }

        private void Button_Signup_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-PQLC5KSC\SQLEXPRESS;Initial Catalog=""TV Favorites"";Integrated Security=True");
            try
            {
                sqlCon.Open();

                // Check if first name is valid
                if (!IsValidField(txtFirstName.Text))
                {
                    MessageBox.Show("First name is required");
                    return;
                }

                // Check if last name is valid
                if (!IsValidField(txtLastName.Text))
                {
                    MessageBox.Show("Last name is required");
                    return;
                }

                // Check if email is valid
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Invalid email address");
                    return;
                }

                // Check if email already exists
                string query = "SELECT COUNT(*) FROM [User] WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Account with this email already exists");
                    return;
                }

                // Check if password is valid
                if (!IsValidField(txtPassword.Password))
                {
                    MessageBox.Show("Password is required");
                    return;
                }

                // Insert user data into database
                query = "Insert into [User] (firstName, lastname, email, password) values (@FirstName, @LastName, @Email, @Password)";
                cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Password);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { sqlCon.Close(); }

            Log_In log = new Log_In();
            log.Show();
            this.Close();
        }



        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            Log_In log = new Log_In();
            log.Show();
            this.Close();
        }
    }
}
