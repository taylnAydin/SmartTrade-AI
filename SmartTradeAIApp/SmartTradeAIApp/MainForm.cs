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
            this.KeyPreview = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCoin_Click(object sender, EventArgs e)
        {
            
            CoinsForm coinsForm = new CoinsForm(this);
            coinsForm.FormClosed += (s, args) => this.Show(); 
            this.Hide(); 
            coinsForm.Show(); 
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void prtf_btn_Click(object sender, EventArgs e)
        {
            PortfolioForm portfolioForm = new PortfolioForm(this);
            portfolioForm.FormClosed += (s, args) => this.Show(); 
            this.Hide(); 
            portfolioForm.Show();
        }

        private void watchList_Click(object sender, EventArgs e)
        {
            WatchListForm watchForm = new WatchListForm(this);
            watchForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            watchForm.Show();
        }
    }
}

