using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTradeAIApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enable key preview to handle ESC key globally
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Handle any initial setup when the main form loads
        }

        private void btnCoin_Click(object sender, EventArgs e)
        {
            // Open the CoinsForm and hide the main form
            CoinsForm coinsForm = new CoinsForm(this);
            coinsForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            coinsForm.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Check if ESC key is pressed
            if (keyData == Keys.Escape)
            {
                // Ask the user if they want to close the application
                DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return true; // Indicate the key press has been handled
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void prtf_btn_Click(object sender, EventArgs e)
        {
            // Open the PortfolioForm and hide the main form
            PortfolioForm portfolioForm = new PortfolioForm(this);
            portfolioForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            portfolioForm.Show();
        }

        private void watchList_Click(object sender, EventArgs e)
        {
            // Open the WatchListForm and hide the main form
            WatchListForm watchForm = new WatchListForm(this);
            watchForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            watchForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask the user if they want to close the application
            DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the close event if the user selects "No"
            }
        }
    }
}
