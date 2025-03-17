using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartTradeAIApp
{
    public partial class PortfolioForm : Form
    {
        private MainForm mainForm;

        // Connection string for MySQL
        private string connectionString = "server=127.0.0.1;uid=root;pwd=mimoit50;database=smartradeai";
        public PortfolioForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.KeyPreview = true;
        }

        private void PortfolioForm_Load(object sender, EventArgs e)
        {
            // Refresh the ListView when the form loads
            RefreshListView();
        }

        // Fetches data from MySQL and displays it in the ListView
        private void RefreshListView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to fetch all data from the coins table
                    string query = "SELECT name, price, amount, note FROM coins";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Clear existing items in the ListView
                            coins_view.Items.Clear();

                            // Add each row from the database to the ListView
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["name"].ToString());
                                item.SubItems.Add(reader["price"].ToString());
                                item.SubItems.Add(reader["amount"].ToString());
                                item.SubItems.Add(reader["note"].ToString());
                                coins_view.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if data retrieval fails
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Adds a new record to the MySQL database
        private void AddToDatabase(string name, decimal price, decimal amount, string note)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Insert query
                    string query = "INSERT INTO coins (name, price, amount, note) VALUES (@name, @price, @amount, @note)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Add parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@price", price);
                        command.Parameters.AddWithValue("@amount", amount);
                        command.Parameters.AddWithValue("@note", note);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Show error message if adding to the database fails
                MessageBox.Show("An error occurred while adding to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // Get user input from textboxes
            string name = name_box.Text;
            decimal price = decimal.Parse(price_box.Text);
            decimal amount = decimal.Parse(amount_box.Text);
            string note = note_box.Text;

            // Add the new record to the database
            AddToDatabase(name, price, amount, note);

            // Refresh the ListView to show the newly added record
            RefreshListView();

            // Clear input fields
            name_box.Clear();
            price_box.Clear();
            amount_box.Clear();
            note_box.Clear();
        }

        private void PortfolioForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Hide the current form and show the main menu if ESC is pressed
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                mainForm.Show();
            }
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            // Hide the current form and show the main menu when Back button is clicked
            this.Hide();
            mainForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Check if any item is selected in the ListView
            if (coins_view.SelectedItems.Count > 0)
            {
                // Get the name of the selected item (first column text)
                string nameToDelete = coins_view.SelectedItems[0].Text;

                // Connect to the MySQL database and delete the item
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM coins WHERE name = @name";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@name", nameToDelete);
                        command.ExecuteNonQuery();
                    }
                }

                // Remove the item from the ListView
                coins_view.Items.Remove(coins_view.SelectedItems[0]);
            }
        }
    }
}
