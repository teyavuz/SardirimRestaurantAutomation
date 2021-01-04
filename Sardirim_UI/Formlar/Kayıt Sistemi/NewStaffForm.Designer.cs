namespace Sardirim_UI.Formlar.Kayıt_Sistemi
{
    partial class NewStaffForm
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
            this.txtStaffPhoneMasked = new System.Windows.Forms.MaskedTextBox();
            this.chkCheck = new MetroFramework.Controls.MetroRadioButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtStaffSurname = new MetroFramework.Controls.MetroTextBox();
            this.txtStaffName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.cmbStaffType = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "YENİ ÇALIŞAN KAYIT EKRANI";
            // 
            // txtStaffPhoneMasked
            // 
            this.txtStaffPhoneMasked.Location = new System.Drawing.Point(170, 170);
            this.txtStaffPhoneMasked.Mask = "9990000000";
            this.txtStaffPhoneMasked.Name = "txtStaffPhoneMasked";
            this.txtStaffPhoneMasked.Size = new System.Drawing.Size(185, 20);
            this.txtStaffPhoneMasked.TabIndex = 11;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(222, 337);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(51, 15);
            this.chkCheck.TabIndex = 18;
            this.chkCheck.Text = "Onay";
            this.chkCheck.UseSelectable = true;
            this.chkCheck.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(279, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 283);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "Statü:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(51, 170);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "Telefon Numarası:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(51, 132);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Çalışan Soyadı:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(51, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Çalışan Adı:";
            // 
            // txtStaffSurname
            // 
            // 
            // 
            // 
            this.txtStaffSurname.CustomButton.Image = null;
            this.txtStaffSurname.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtStaffSurname.CustomButton.Name = "";
            this.txtStaffSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStaffSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffSurname.CustomButton.TabIndex = 1;
            this.txtStaffSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffSurname.CustomButton.UseSelectable = true;
            this.txtStaffSurname.CustomButton.Visible = false;
            this.txtStaffSurname.Lines = new string[0];
            this.txtStaffSurname.Location = new System.Drawing.Point(170, 132);
            this.txtStaffSurname.MaxLength = 32767;
            this.txtStaffSurname.Name = "txtStaffSurname";
            this.txtStaffSurname.PasswordChar = '\0';
            this.txtStaffSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffSurname.SelectedText = "";
            this.txtStaffSurname.SelectionLength = 0;
            this.txtStaffSurname.SelectionStart = 0;
            this.txtStaffSurname.ShortcutsEnabled = true;
            this.txtStaffSurname.Size = new System.Drawing.Size(186, 23);
            this.txtStaffSurname.TabIndex = 10;
            this.txtStaffSurname.UseSelectable = true;
            this.txtStaffSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStaffName
            // 
            // 
            // 
            // 
            this.txtStaffName.CustomButton.Image = null;
            this.txtStaffName.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtStaffName.CustomButton.Name = "";
            this.txtStaffName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStaffName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStaffName.CustomButton.TabIndex = 1;
            this.txtStaffName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStaffName.CustomButton.UseSelectable = true;
            this.txtStaffName.CustomButton.Visible = false;
            this.txtStaffName.Lines = new string[0];
            this.txtStaffName.Location = new System.Drawing.Point(170, 88);
            this.txtStaffName.MaxLength = 32767;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.PasswordChar = '\0';
            this.txtStaffName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStaffName.SelectedText = "";
            this.txtStaffName.SelectionLength = 0;
            this.txtStaffName.SelectionStart = 0;
            this.txtStaffName.ShortcutsEnabled = true;
            this.txtStaffName.Size = new System.Drawing.Size(186, 23);
            this.txtStaffName.TabIndex = 1;
            this.txtStaffName.UseSelectable = true;
            this.txtStaffName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStaffName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(51, 212);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Şube:";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sardirim_UI.Properties.Resources._45d34df4612f4c50e88695e649e7a997;
            this.pictureBox1.Location = new System.Drawing.Point(481, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 379);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "Kadıköy",
            "Bebek",
            "Taksim"});
            this.cmbBranch.Location = new System.Drawing.Point(171, 210);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(185, 21);
            this.cmbBranch.TabIndex = 21;
            // 
            // cmbStaffType
            // 
            this.cmbStaffType.FormattingEnabled = true;
            this.cmbStaffType.Items.AddRange(new object[] {
            "Mutfak Elemanı",
            "Garson",
            "Vale"});
            this.cmbStaffType.Location = new System.Drawing.Point(170, 283);
            this.cmbStaffType.Name = "cmbStaffType";
            this.cmbStaffType.Size = new System.Drawing.Size(184, 21);
            this.cmbStaffType.TabIndex = 22;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbGender.Location = new System.Drawing.Point(170, 248);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(186, 21);
            this.cmbGender.TabIndex = 23;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(51, 248);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(56, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Cinsiyet:";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // NewStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.cmbStaffType);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStaffPhoneMasked);
            this.Controls.Add(this.chkCheck);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtStaffSurname);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewStaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewStaffForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtStaffPhoneMasked;
        private MetroFramework.Controls.MetroRadioButton chkCheck;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtStaffSurname;
        private MetroFramework.Controls.MetroTextBox txtStaffName;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.ComboBox cmbStaffType;
        private System.Windows.Forms.ComboBox cmbGender;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}