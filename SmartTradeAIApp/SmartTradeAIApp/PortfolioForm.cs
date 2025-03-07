using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SmartTradeAIApp
{
    public partial class PortfolioForm : Form
    {
        private MainForm mainForm;
        private string connectionString = "Your SQL Connection Here!!!";

        public PortfolioForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.KeyPreview = true;
        }

        private void PortfolioForm_Load(object sender, EventArgs e)
        {
            RefreshListView();
        }

        private void AddToDatabase(string name, decimal price, decimal amount, string note)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO coins (name, price, amount, note) VALUES (@name, @price, @amount, @note)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
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
                MessageBox.Show("An error occurred while adding to the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshListView()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name, price, amount, note FROM coins";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            coins_view.Items.Clear();

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
                MessageBox.Show("An error occurred while retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // Get user input
            string name = name_box.Text;
            decimal price = decimal.Parse(price_box.Text);
            decimal amount = decimal.Parse(amount_box.Text);
            string note = note_box.Text;

            // Add to database
            AddToDatabase(name, price, amount, note);

            // Refresh ListView
            RefreshListView();

            // Clear textboxes
            name_box.Clear();
            price_box.Clear();
            amount_box.Clear();
            note_box.Clear();
        }

        private void PortfolioForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                mainForm.Show();
            }
        }

        private void bck_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
    }
}
