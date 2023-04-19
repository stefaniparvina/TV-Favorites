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
        private void Button_Signup_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-PQLC5KSC\SQLEXPRESS;Initial Catalog=""TV Favorites"";Integrated Security=True");
            try
            {
                sqlCon.Open();
                string query = "Insert into [User] (firstName, lastname, email, password) values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtEmail.Text + "','" + txtPassword.Password + "')";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
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

        private void txtFirstName1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
