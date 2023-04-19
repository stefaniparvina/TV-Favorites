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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TV_Favorites
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void logo_button_Click(object sender, RoutedEventArgs e)
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

        private void watchList_button_Click(object sender, RoutedEventArgs e)
        {
            Watch_List wl = new Watch_List();
            wl.Show();
            this.Close();
        }
    }
}
