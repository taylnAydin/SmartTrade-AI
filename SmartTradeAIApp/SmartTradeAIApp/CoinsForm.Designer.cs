﻿namespace SmartTradeAIApp
{
    partial class CoinsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinsForm));
            this.bck_btn = new System.Windows.Forms.Button();
            this.shw_btn = new System.Windows.Forms.Button();
            this.listViewCoins = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTitle = new System.Windows.Forms.Label();
            this.chartPrices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // bck_btn
            // 
            this.bck_btn.BackColor = System.Drawing.Color.AliceBlue;
            this.bck_btn.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.bck_btn.Location = new System.Drawing.Point(1394, 802);
            this.bck_btn.Name = "bck_btn";
            this.bck_btn.Size = new System.Drawing.Size(168, 47);
            this.bck_btn.TabIndex = 0;
            this.bck_btn.Text = "BACK";
            this.bck_btn.UseVisualStyleBackColor = false;
            this.bck_btn.Click += new System.EventHandler(this.bck_btn_Click);
            // 
            // shw_btn
            // 
            this.shw_btn.BackColor = System.Drawing.Color.AliceBlue;
            this.shw_btn.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.shw_btn.Location = new System.Drawing.Point(28, 802);
            this.shw_btn.Name = "shw_btn";
            this.shw_btn.Size = new System.Drawing.Size(433, 47);
            this.shw_btn.TabIndex = 2;
            this.shw_btn.Text = "SHOW";
            this.shw_btn.UseVisualStyleBackColor = false;
            // 
            // listViewCoins
            // 
            this.listViewCoins.BackColor = System.Drawing.Color.DarkGray;
            this.listViewCoins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCoins.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.listViewCoins.FullRowSelect = true;
            this.listViewCoins.HideSelection = false;
            this.listViewCoins.Location = new System.Drawing.Point(28, 92);
            this.listViewCoins.MultiSelect = false;
            this.listViewCoins.Name = "listViewCoins";
            this.listViewCoins.Size = new System.Drawing.Size(433, 671);
            this.listViewCoins.TabIndex = 3;
            this.listViewCoins.UseCompatibleStateImageBehavior = false;
            this.listViewCoins.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "        Coin Name";
            this.columnHeader1.Width = 450;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 21.75F);
            this.lblTitle.Location = new System.Drawing.Point(23, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(438, 29);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Top 25 Coins - 24h Volume";
            // 
            // chartPrices
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPrices.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPrices.Legends.Add(legend1);
            this.chartPrices.Location = new System.Drawing.Point(595, 92);
            this.chartPrices.Name = "chartPrices";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPrices.Series.Add(series1);
            this.chartPrices.Size = new System.Drawing.Size(967, 671);
            this.chartPrices.TabIndex = 5;
            this.chartPrices.Text = "chart1";
            // 
            // CoinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.chartPrices);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.listViewCoins);
            this.Controls.Add(this.shw_btn);
            this.Controls.Add(this.bck_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CoinsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTrade AI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CoinsForm_FormClosed);
            this.Load += new System.EventHandler(this.CoinsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CoinsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.chartPrices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bck_btn;
        private System.Windows.Forms.Button shw_btn;
        private System.Windows.Forms.ListView listViewCoins;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPrices;
    }
}