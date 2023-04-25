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

namespace TV_Favorites
{
    public partial class Watch_List : Window
    {
        private UserLoginState loginState;
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-PQLC5KSC\SQLEXPRESS;Initial Catalog=""TV Favorites"";Integrated Security=True");
        private SqlDataAdapter sqlAdapter;
        private DataTable table;
        public Watch_List()
        {
            loginState = (UserLoginState)Properties.Settings.Default.UserLoginState;
            if (loginState == null || loginState.IsLoggedIn == false)
            {
                Sign_Up sign_Up = new Sign_Up();
                sign_Up.Show();
                this.Close();
            }
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            sqlCon.Open();
            string query = "SELECT Watchlist.id, Series.title AS Title FROM WatchList INNER JOIN Series ON WatchList.seriesId = Series.id WHERE WatchList.userId = @userId";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@userId", loginState.Id);

            sqlAdapter = new SqlDataAdapter(sqlCmd);
            table = new DataTable();
            sqlAdapter.Fill(table);

            watchListDataGrid.ItemsSource = table.DefaultView;

            sqlCon.Close();
        }


        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView rowView = (DataRowView)watchListDataGrid.SelectedItem;

            int watchlistId = Convert.ToInt32(rowView["id"]);

            sqlCon.Open();
            string deleteQuery = "DELETE FROM WatchList WHERE id = @watchlistId";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, sqlCon);
            deleteCmd.CommandType = CommandType.Text;
            deleteCmd.Parameters.AddWithValue("@watchlistId", watchlistId);
            deleteCmd.ExecuteNonQuery();
            sqlCon.Close();

            table.Rows.Remove(rowView.Row);
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

        private void previousPage_button_Click(object sender, RoutedEventArgs e)
        {
            Profile p = new Profile();
            p.Show();
            this.Close();
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
