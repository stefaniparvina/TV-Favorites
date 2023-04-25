using System;
using System.Collections;
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

namespace TV_Favorites
{
    /// <summary>
    /// Interaction logic for Game_Of_Thrones.xaml
    /// </summary>
    public partial class Game_Of_Thrones : Window
    {
        private const int seriesId = 1;
        private bool inList = false;
        private UserLoginState loginState;
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-PQLC5KSC\SQLEXPRESS;Initial Catalog=""TV Favorites"";Integrated Security=True");
        public Game_Of_Thrones()
        {
            loginState = (UserLoginState)Properties.Settings.Default.UserLoginState;
            if (loginState == null || loginState.IsLoggedIn == false)
            {
                Sign_Up sign_Up = new Sign_Up();
                sign_Up.Show();
                this.Close();
            }

            InitializeComponent();

            sqlCon.Open();

            string query = "SELECT * FROM [WatchList] WHERE userId=@userId AND seriesId=@seriesId";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@userId", loginState.Id);
            sqlCmd.Parameters.AddWithValue("@seriesId", seriesId);
            SqlDataReader reader;
            reader = sqlCmd.ExecuteReader();

            if (reader.HasRows)
            {
                inList = true;
                toggle_series.Content = "Remove from Watchlist";
            }
            reader.Close();
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

        private void Toggle_Series_Button_Click(object sender, RoutedEventArgs e)
        {
            string query = "INSERT INTO [WatchList] ([userId],[seriesId]) VALUES(@userId,@seriesId)";
            if (inList)
            {
                query = "DELETE FROM [WatchList] WHERE userId=@userId AND seriesId=@seriesId";
            }
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@userId", loginState.Id);
            sqlCmd.Parameters.AddWithValue("@seriesId", seriesId);
            sqlCmd.ExecuteNonQuery();
            inList = !inList;
            toggle_series.Content = inList ? "Remove from Watchlist" : "Add to Watchlist";
        }

        private void myComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem selectedItem = (ComboBoxItem)myComboBox.SelectedItem;
            string selectedItemText = selectedItem.Content.ToString();

            switch (selectedItemText)
            {
                case "Game of Thrones":
                    Game_Of_Thrones got = new Game_Of_Thrones();
                    got.Show();
                    this.Close();
                    break;
                case "Gossip Girl":
                    Gossip_Girl gg = new Gossip_Girl();
                    gg.Show();
                    this.Close();
                    break;
                case "Friends":
                    Friends fr = new Friends();
                    fr.Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }
    }
}
