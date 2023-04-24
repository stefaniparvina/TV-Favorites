using System;
using System.Collections.Generic;
using System.Data;
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
using TV_Favorites;


namespace TV_Favorites
{
    /// <summary>
    /// Interaction logic for Main_Page.xaml
    /// </summary>
    public partial class Main_Page : Window
    {
        public Main_Page()
        {
            UserLoginState loginState = (UserLoginState)Properties.Settings.Default.UserLoginState;
            if (loginState == null || loginState.IsLoggedIn == false)
            {
                Sign_Up sign_Up = new Sign_Up();
                sign_Up.Show();
                this.Close();
            }

            InitializeComponent();
        }

        private void got_button_Click(object sender, RoutedEventArgs e)
        {
            Game_Of_Thrones got = new Game_Of_Thrones();
            got.Show();
            this.Close();
        }

        private void gg_button_Click(object sender, RoutedEventArgs e)
        {
            Gossip_Girl gg = new Gossip_Girl();
            gg.Show();
            this.Close();
        }

        private void friends_button_Click(object sender, RoutedEventArgs e)
        {
            Friends fr = new Friends();
            fr.Show();
            this.Close();
        }

        private void profile_button_Click(object sender, RoutedEventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Close();
        }

        private void got_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Game_Of_Thrones got = new Game_Of_Thrones();
            got.Show();
            this.Close();
        }

        private void gg_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Gossip_Girl gg = new Gossip_Girl();
            gg.Show();
            this.Close();
        }
        private void friends_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Friends fr = new Friends();
            fr.Show();
            this.Close();
        }
    }
}
