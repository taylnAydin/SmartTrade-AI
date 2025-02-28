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
    public partial class WatchListForm : Form
    {
        private MainForm mainForm;
        public WatchListForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.KeyPreview = true;
            this.mainForm = mainForm;
        }

        private void WatchListForm_Load(object sender, EventArgs e)
        {

        }

        private void WatchListForm_KeyDown(object sender, KeyEventArgs e)
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
