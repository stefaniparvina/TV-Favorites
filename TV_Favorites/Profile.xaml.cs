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

namespace TV_Favorites
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Window
    {
        private UserLoginState loginState;
        SqlConnection sqlCon = new SqlConnection(@"Data Source=LAPTOP-PQLC5KSC\SQLEXPRESS;Initial Catalog=""TV Favorites"";Integrated Security=True");
        private SqlDataAdapter sqlAdapter;
        private DataTable table;
        public Profile()
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
            string query = "SELECT id as [ID], email as [Email], firstName as [First Name], lastName as [Last Name], birthday as [Birthday] FROM [User] WHERE id=@userId";
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@userId", loginState.Id);

            sqlAdapter = new SqlDataAdapter(sqlCmd);
            table = new DataTable();
            sqlAdapter.Fill(table);
            profile.ItemsSource = table.DefaultView;
        }

        private void UpdateData()
        {
            try
            {
                SqlCommandBuilder sqlBuilder = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.UpdateCommand = sqlBuilder.GetUpdateCommand();

                table.GetChanges();
                sqlAdapter.Update(table);
                table.AcceptChanges();
                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data." + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void saveChanges_Click(object sender, RoutedEventArgs e)
        {
            UpdateData();
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
