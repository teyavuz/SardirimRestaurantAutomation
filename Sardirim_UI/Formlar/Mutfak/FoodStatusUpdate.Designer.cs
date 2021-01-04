namespace Sardirim_UI.Formlar.Mutfak
{
    partial class FoodStatusUpdate
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstFoodStatuesCheck = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbFoodStatesUpdate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sardirim_UI.Properties.Resources._45d34df4612f4c50e88695e649e7a997;
            this.pictureBox1.Location = new System.Drawing.Point(795, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lstFoodStatuesCheck
            // 
            this.lstFoodStatuesCheck.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstFoodStatuesCheck.FullRowSelect = true;
            this.lstFoodStatuesCheck.HideSelection = false;
            this.lstFoodStatuesCheck.Location = new System.Drawing.Point(13, 13);
            this.lstFoodStatuesCheck.Name = "lstFoodStatuesCheck";
            this.lstFoodStatuesCheck.Size = new System.Drawing.Size(752, 392);
            this.lstFoodStatuesCheck.TabIndex = 6;
            this.lstFoodStatuesCheck.UseCompatibleStateImageBehavior = false;
            this.lstFoodStatuesCheck.View = System.Windows.Forms.View.Details;
            this.lstFoodStatuesCheck.SelectedIndexChanged += new System.EventHandler(this.lstFoodStatuesCheck_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OrderID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Masa";
            this.columnHeader2.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri";
            this.columnHeader3.Width = 138;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Siparişi Alan";
            this.columnHeader4.Width = 170;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yemeğin Durumu";
            this.columnHeader5.Width = 197;
            // 
            // cmbFoodStatesUpdate
            // 
            this.cmbFoodStatesUpdate.FormattingEnabled = true;
            this.cmbFoodStatesUpdate.Items.AddRange(new object[] {
            "Sipariş Alındı ID1",
            "Hazırlanıyor ID2",
            "Pişiyor ID3",
            "Servis Bekliyor ID4",
            "Hazır ID5"});
            this.cmbFoodStatesUpdate.Location = new System.Drawing.Point(13, 423);
            this.cmbFoodStatesUpdate.Name = "cmbFoodStatesUpdate";
            this.cmbFoodStatesUpdate.Size = new System.Drawing.Size(200, 21);
            this.cmbFoodStatesUpdate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoodStatusUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFoodStatesUpdate);
            this.Controls.Add(this.lstFoodStatuesCheck);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodStatusUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FoodStatus";
            this.Load += new System.EventHandler(this.FoodStatusUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lstFoodStatuesCheck;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cmbFoodStatesUpdate;
        private System.Windows.Forms.Button button1;
    }
}