using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace TV_Favorites
{
    /// <summary>
    /// Interaction logic for Game_Of_Thrones.xaml
    /// </summary>
    public partial class Game_Of_Thrones : Window
    {
        public Game_Of_Thrones()
        {
            InitializeComponent();
        }

        private void logo_Button_Click(object sender, RoutedEventArgs e)
        {
            Main_Page mp = new Main_Page();
            mp.Show();
            this.Close();
        }

        private void mainPage_link_Click(object sender, RoutedEventArgs e)
        {
            Main_Page mp = new Main_Page();
            mp.Show();
            this.Close();
        }
        private void profile_Link_Click(object sender, RoutedEventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Close();
        }

        private void WatchList_Button_Click(object sender, RoutedEventArgs e)
        {
            /*SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-PQLC5KSC\SQLEXPRESS;Initial Catalog=""TV Favorites"";Integrated Security=True");
            try
            {
                sqlCon.Open();
                string query = "INSERT INTO [User] (firstName, lastName, email, password) VALUES (@FirstName, @LastName, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@FirstName", sender.txtFirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", sender.txtLastName.Text);
                cmd.Parameters.AddWithValue("@Email", sender.txtEmail.Text);
                cmd.Parameters.AddWithValue("@Password", sender.txtPassword.Password);
                cmd.ExecuteNonQuery();

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
            this.Close();*/

        }
    }
}
