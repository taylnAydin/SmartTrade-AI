namespace SmartTradeAIApp
{
    partial class PortfolioForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioForm));
            this.bck_btn = new System.Windows.Forms.Button();
            this.name_lbl = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.price_lbl = new System.Windows.Forms.Label();
            this.price_box = new System.Windows.Forms.TextBox();
            this.amount_lbl = new System.Windows.Forms.Label();
            this.amount_box = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.coins_view = new System.Windows.Forms.ListView();
            this.name_colmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price_colmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_colmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note_colmn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note_lbl = new System.Windows.Forms.Label();
            this.note_box = new System.Windows.Forms.TextBox();
            this.portfolio_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.portfolio_chart)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.Color.AliceBlue;
            this.bck_btn.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.bck_btn.Location = new System.Drawing.Point(1388, 802);
            this.bck_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(159, 36);
            this.bck_btn.TabIndex = 1;
            this.bck_btn.Text = "BACK";
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.name_lbl.ForeColor = System.Drawing.Color.White;
            this.name_lbl.Location = new System.Drawing.Point(42, 98);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(98, 29);
            this.name_lbl.TabIndex = 2;
            this.name_lbl.Text = "NAME ";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(179, 91);
            this.name_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(144, 36);
            this.name_box.TabIndex = 3;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.price_lbl.ForeColor = System.Drawing.Color.White;
            this.price_lbl.Location = new System.Drawing.Point(42, 184);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(98, 29);
            this.price_lbl.TabIndex = 4;
            this.price_lbl.Text = "PRICE";
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(179, 177);
            this.price_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(144, 36);
            this.price_box.TabIndex = 5;
            // 
            // amount_lbl
            // 
            this.amount_lbl.AutoSize = true;
            this.amount_lbl.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.amount_lbl.ForeColor = System.Drawing.Color.White;
            this.amount_lbl.Location = new System.Drawing.Point(42, 266);
            this.amount_lbl.Name = "amount_lbl";
            this.amount_lbl.Size = new System.Drawing.Size(115, 29);
            this.amount_lbl.TabIndex = 6;
            this.amount_lbl.Text = "AMOUNT";
            // 
            // amount_box
            // 
            this.amount_box.Location = new System.Drawing.Point(179, 263);
            this.amount_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amount_box.Name = "amount_box";
            this.amount_box.Size = new System.Drawing.Size(144, 36);
            this.amount_box.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.AliceBlue;
            this.add_btn.Location = new System.Drawing.Point(47, 433);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(276, 36);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // coins_view
            // 
            this.coins_view.BackColor = System.Drawing.Color.DarkGray;
            this.coins_view.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_colmn,
            this.price_colmn,
            this.amount_colmn,
            this.note_colmn});
            this.coins_view.ContextMenuStrip = this.contextMenuStrip1;
            this.coins_view.FullRowSelect = true;
            this.coins_view.HideSelection = false;
            this.coins_view.Location = new System.Drawing.Point(401, 34);
            this.coins_view.MultiSelect = false;
            this.coins_view.Name = "coins_view";
            this.coins_view.Size = new System.Drawing.Size(663, 715);
            this.coins_view.TabIndex = 9;
            this.coins_view.UseCompatibleStateImageBehavior = false;
            this.coins_view.View = System.Windows.Forms.View.Details;
            // 
            // name_colmn
            // 
            this.name_colmn.Text = "NAME";
            this.name_colmn.Width = 160;
            // 
            // price_colmn
            // 
            this.price_colmn.Text = "PRICE";
            this.price_colmn.Width = 160;
            // 
            // amount_colmn
            // 
            this.amount_colmn.Text = "AMOUNT";
            this.amount_colmn.Width = 160;
            // 
            // note_colmn
            // 
            this.note_colmn.Text = "NOTE";
            this.note_colmn.Width = 180;
            // 
            // note_lbl
            // 
            this.note_lbl.AutoSize = true;
            this.note_lbl.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.note_lbl.ForeColor = System.Drawing.Color.White;
            this.note_lbl.Location = new System.Drawing.Point(42, 348);
            this.note_lbl.Name = "note_lbl";
            this.note_lbl.Size = new System.Drawing.Size(81, 29);
            this.note_lbl.TabIndex = 10;
            this.note_lbl.Text = "NOTE";
            // 
            // note_box
            // 
            this.note_box.Location = new System.Drawing.Point(179, 341);
            this.note_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.note_box.Name = "note_box";
            this.note_box.Size = new System.Drawing.Size(144, 36);
            this.note_box.TabIndex = 11;
            // 
            // portfolio_chart
            // 
            this.portfolio_chart.BackColor = System.Drawing.Color.MidnightBlue;
            this.portfolio_chart.BackSecondaryColor = System.Drawing.Color.MidnightBlue;
            this.portfolio_chart.BorderlineColor = System.Drawing.Color.MidnightBlue;
            chartArea1.Name = "ChartArea1";
            this.portfolio_chart.ChartAreas.Add(chartArea1);
            this.portfolio_chart.Cursor = System.Windows.Forms.Cursors.Default;
            legend1.Name = "Legend1";
            this.portfolio_chart.Legends.Add(legend1);
            this.portfolio_chart.Location = new System.Drawing.Point(1115, 12);
            this.portfolio_chart.Name = "portfolio_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.portfolio_chart.Series.Add(series1);
            this.portfolio_chart.Size = new System.Drawing.Size(457, 755);
            this.portfolio_chart.TabIndex = 12;
            this.portfolio_chart.Text = "chart1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Window;
            this.monthCalendar1.Location = new System.Drawing.Point(67, 587);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(180, 22);
            this.delete.Text = "Delete";
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.portfolio_chart);
            this.Controls.Add(this.note_box);
            this.Controls.Add(this.note_lbl);
            this.Controls.Add(this.coins_view);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.amount_box);
            this.Controls.Add(this.amount_lbl);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.price_lbl);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.bck_btn);
            this.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "PortfolioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTrade AI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.PortfolioForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PortfolioForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.portfolio_chart)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bck_btn;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label price_lbl;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.Label amount_lbl;
        private System.Windows.Forms.TextBox amount_box;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.ListView coins_view;
        private System.Windows.Forms.Label note_lbl;
        private System.Windows.Forms.TextBox note_box;
        private System.Windows.Forms.ColumnHeader name_colmn;
        private System.Windows.Forms.ColumnHeader price_colmn;
        private System.Windows.Forms.ColumnHeader amount_colmn;
        private System.Windows.Forms.ColumnHeader note_colmn;
        private System.Windows.Forms.DataVisualization.Charting.Chart portfolio_chart;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delete;
    }
}