using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TV_Favorites;
using System.Runtime.Remoting.Messaging;

namespace TV_Favorites
{
    /// <summary>
    /// Interaction logic for Log_In.xaml
    /// </summary>
    public partial class Log_In : Window
    {
        public Log_In()
        {
            UserLoginState loginState = (UserLoginState)Properties.Settings.Default.UserLoginState;
            if (loginState != null && loginState.IsLoggedIn)
            {
                Main_Page main_Page = new Main_Page();
                main_Page.Show();
                this.Close();
            }
            InitializeComponent();
        }

        private void Button_login_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-PQLC5KSC\SQLEXPRESS;Initial Catalog=""TV Favorites"";Integrated Security=True");

            try
            {
                sqlCon.Open();

                string query = "SELECT id, email, firstName, lastName, birthday FROM [User] WHERE email=@email AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Password);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();

                    // Set the login state
                    Properties.Settings.Default.UserLoginState = new UserLoginState
                    {
                        IsLoggedIn = true,
                        Id = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                        Email = reader.IsDBNull(1) ? null : reader.GetString(1),
                        FirstName = reader.IsDBNull(2) ? null : reader.GetString(2),
                        LastName = reader.IsDBNull(3) ? null : reader.GetString(3),
                        BirthDay = reader.IsDBNull(4) ? DateTime.MinValue : reader.GetDateTime(4)
                    };
                    Properties.Settings.Default.Save();

                    Main_Page dashboard = new Main_Page();
                    dashboard.Show();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Username or password are not correct!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }


        private void Signup_button_Click(object sender, RoutedEventArgs e)
        {
            Sign_Up sign = new Sign_Up();
            sign.Show();
            this.Close();
        }
    }
}
