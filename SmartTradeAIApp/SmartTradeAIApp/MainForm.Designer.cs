namespace SmartTradeAIApp
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnCoin = new System.Windows.Forms.Button();
            this.watchList = new System.Windows.Forms.Button();
            this.prtf_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCoin
            // 
            this.btnCoin.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCoin.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoin.Location = new System.Drawing.Point(576, 209);
            this.btnCoin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCoin.Name = "btnCoin";
            this.btnCoin.Size = new System.Drawing.Size(524, 79);
            this.btnCoin.TabIndex = 0;
            this.btnCoin.Text = "C O I N S";
            this.btnCoin.UseVisualStyleBackColor = false;
            this.btnCoin.Click += new System.EventHandler(this.btnCoin_Click);
            // 
            // watchList
            // 
            this.watchList.BackColor = System.Drawing.Color.AliceBlue;
            this.watchList.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchList.Location = new System.Drawing.Point(576, 409);
            this.watchList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.watchList.Name = "watchList";
            this.watchList.Size = new System.Drawing.Size(524, 79);
            this.watchList.TabIndex = 1;
            this.watchList.Text = "W A T C H   L I S T";
            this.watchList.UseVisualStyleBackColor = false;
            this.watchList.Click += new System.EventHandler(this.watchList_Click);
            // 
            // prtf_btn
            // 
            this.prtf_btn.BackColor = System.Drawing.Color.AliceBlue;
            this.prtf_btn.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prtf_btn.Location = new System.Drawing.Point(576, 611);
            this.prtf_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prtf_btn.Name = "prtf_btn";
            this.prtf_btn.Size = new System.Drawing.Size(524, 79);
            this.prtf_btn.TabIndex = 2;
            this.prtf_btn.Text = "P O R T F O L I O";
            this.prtf_btn.UseVisualStyleBackColor = false;
            this.prtf_btn.Click += new System.EventHandler(this.prtf_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.prtf_btn);
            this.Controls.Add(this.watchList);
            this.Controls.Add(this.btnCoin);
            this.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartTrade AI";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCoin;
        private System.Windows.Forms.Button watchList;
        private System.Windows.Forms.Button prtf_btn;
    }
}

