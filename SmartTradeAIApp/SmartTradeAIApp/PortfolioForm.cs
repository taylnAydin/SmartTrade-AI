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
    public partial class PortfolioForm : Form
    {
        private MainForm mainForm;
        public PortfolioForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.KeyPreview = true;
            

        }

        private void PortfolioForm_Load(object sender, EventArgs e)
        {

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
