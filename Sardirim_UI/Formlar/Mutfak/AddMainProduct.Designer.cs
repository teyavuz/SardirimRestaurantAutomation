namespace Sardirim_UI.Formlar.Mutfak
{
    partial class AddMainProduct
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
            this.btnAddMain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMainPriceMasked = new System.Windows.Forms.MaskedTextBox();
            this.txtMainName = new System.Windows.Forms.TextBox();
            this.nmrPiece = new System.Windows.Forms.NumericUpDown();
            this.txtMaskedGram = new System.Windows.Forms.MaskedTextBox();
            this.radioPiece = new System.Windows.Forms.RadioButton();
            this.radioGram = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMainProductSelect = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMain
            // 
            this.btnAddMain.Location = new System.Drawing.Point(281, 176);
            this.btnAddMain.Name = "btnAddMain";
            this.btnAddMain.Size = new System.Drawing.Size(75, 23);
            this.btnAddMain.TabIndex = 8;
            this.btnAddMain.Text = "Ekle";
            this.btnAddMain.UseVisualStyleBackColor = true;
            this.btnAddMain.Click += new System.EventHandler(this.btnAddMain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(57, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ürün Fiyatı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ürün Adı:";
            // 
            // txtMainPriceMasked
            // 
            this.txtMainPriceMasked.Location = new System.Drawing.Point(155, 128);
            this.txtMainPriceMasked.Mask = "00000.00";
            this.txtMainPriceMasked.Name = "txtMainPriceMasked";
            this.txtMainPriceMasked.Size = new System.Drawing.Size(202, 20);
            this.txtMainPriceMasked.TabIndex = 5;
            this.txtMainPriceMasked.ValidatingType = typeof(int);
            // 
            // txtMainName
            // 
            this.txtMainName.Location = new System.Drawing.Point(154, 94);
            this.txtMainName.Name = "txtMainName";
            this.txtMainName.Size = new System.Drawing.Size(202, 20);
            this.txtMainName.TabIndex = 4;
            // 
            // nmrPiece
            // 
            this.nmrPiece.Enabled = false;
            this.nmrPiece.Location = new System.Drawing.Point(155, 373);
            this.nmrPiece.Name = "nmrPiece";
            this.nmrPiece.Size = new System.Drawing.Size(192, 20);
            this.nmrPiece.TabIndex = 12;
            // 
            // txtMaskedGram
            // 
            this.txtMaskedGram.Enabled = false;
            this.txtMaskedGram.Location = new System.Drawing.Point(155, 346);
            this.txtMaskedGram.Mask = "000000.000";
            this.txtMaskedGram.Name = "txtMaskedGram";
            this.txtMaskedGram.Size = new System.Drawing.Size(193, 20);
            this.txtMaskedGram.TabIndex = 11;
            this.txtMaskedGram.ValidatingType = typeof(int);
            // 
            // radioPiece
            // 
            this.radioPiece.AutoSize = true;
            this.radioPiece.Location = new System.Drawing.Point(70, 376);
            this.radioPiece.Name = "radioPiece";
            this.radioPiece.Size = new System.Drawing.Size(47, 17);
            this.radioPiece.TabIndex = 9;
            this.radioPiece.TabStop = true;
            this.radioPiece.Text = "Adet";
            this.radioPiece.UseVisualStyleBackColor = true;
            this.radioPiece.CheckedChanged += new System.EventHandler(this.radioPiece_CheckedChanged);
            // 
            // radioGram
            // 
            this.radioGram.AutoSize = true;
            this.radioGram.Location = new System.Drawing.Point(70, 349);
            this.radioGram.Name = "radioGram";
            this.radioGram.Size = new System.Drawing.Size(50, 17);
            this.radioGram.TabIndex = 10;
            this.radioGram.TabStop = true;
            this.radioGram.Text = "Gram";
            this.radioGram.UseVisualStyleBackColor = true;
            this.radioGram.CheckedChanged += new System.EventHandler(this.radioGram_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "İlk Stok Girişi:";
            // 
            // cmbMainProductSelect
            // 
            this.cmbMainProductSelect.FormattingEnabled = true;
            this.cmbMainProductSelect.Location = new System.Drawing.Point(155, 309);
            this.cmbMainProductSelect.Name = "cmbMainProductSelect";
            this.cmbMainProductSelect.Size = new System.Drawing.Size(192, 21);
            this.cmbMainProductSelect.TabIndex = 13;
            this.cmbMainProductSelect.SelectedIndexChanged += new System.EventHandler(this.cmbMainProductSelect_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ana Malzeme Kayıt İşlemi:";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(281, 293);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(66, 13);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "Ana Ürün ID";
            // 
            // AddMainProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cmbMainProductSelect);
            this.Controls.Add(this.nmrPiece);
            this.Controls.Add(this.txtMaskedGram);
            this.Controls.Add(this.radioPiece);
            this.Controls.Add(this.radioGram);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddMain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMainPriceMasked);
            this.Controls.Add(this.txtMainName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMainProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddMainProduct";
            this.Load += new System.EventHandler(this.AddMainProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtMainPriceMasked;
        private System.Windows.Forms.TextBox txtMainName;
        private System.Windows.Forms.NumericUpDown nmrPiece;
        private System.Windows.Forms.MaskedTextBox txtMaskedGram;
        private System.Windows.Forms.RadioButton radioPiece;
        private System.Windows.Forms.RadioButton radioGram;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMainProductSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblid;
    }
}