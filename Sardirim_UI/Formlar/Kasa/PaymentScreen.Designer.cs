namespace Sardirim_UI.Formlar.Kasa
{
    partial class PaymentScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstPaymenStatus = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblid = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ödenecek Tutar";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMoney.Location = new System.Drawing.Point(247, 293);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(0, 29);
            this.lblMoney.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(68, 335);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Ödeme Alındı mı?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(252, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ödeme Alındı";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sardirim_UI.Properties.Resources._45d34df4612f4c50e88695e649e7a997;
            this.pictureBox1.Location = new System.Drawing.Point(576, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lstPaymenStatus
            // 
            this.lstPaymenStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2});
            this.lstPaymenStatus.FullRowSelect = true;
            this.lstPaymenStatus.HideSelection = false;
            this.lstPaymenStatus.Location = new System.Drawing.Point(12, 12);
            this.lstPaymenStatus.Name = "lstPaymenStatus";
            this.lstPaymenStatus.Size = new System.Drawing.Size(540, 275);
            this.lstPaymenStatus.TabIndex = 6;
            this.lstPaymenStatus.UseCompatibleStateImageBehavior = false;
            this.lstPaymenStatus.View = System.Windows.Forms.View.Details;
            this.lstPaymenStatus.SelectedIndexChanged += new System.EventHandler(this.lstPaymenStatus_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Odemesi Yapılmayan Masa";
            this.columnHeader4.Width = 141;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Müşteri Adı";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Durum";
            this.columnHeader1.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ücret";
            this.columnHeader2.Width = 75;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(497, 13);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 13);
            this.lblid.TabIndex = 7;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lstPaymenStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PaymentScreen";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstPaymenStatus;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}