namespace SmartTradeAIApp
{
    partial class WatchListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WatchListForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bck_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DarkGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.price,
            this.date});
            this.listView1.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 29);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1528, 752);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "NAME";
            this.name.Width = 520;
            // 
            // price
            // 
            this.price.Text = "PRICE";
            this.price.Width = 500;
            // 
            // date
            // 
            this.date.Text = "DATE";
            this.date.Width = 510;
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.Color.AliceBlue;
            this.bck_btn.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.bck_btn.Location = new System.Drawing.Point(1390, 802);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(168, 47);
            this.bck_btn.TabIndex = 1;
            this.bck_btn.Text = "BACK";
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // WatchListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.bck_btn);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WatchListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTrade AI";
            this.Load += new System.EventHandler(this.WatchListForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WatchListForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button bck_btn;
    }
}