namespace Sardirim_UI.Formlar.Mutfak
{
    partial class AddFood
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
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodPriceMasked = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cmbSelectFood = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblfoodid = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioGram = new System.Windows.Forms.RadioButton();
            this.radioPiece = new System.Windows.Forms.RadioButton();
            this.txtMaskedGram = new System.Windows.Forms.MaskedTextBox();
            this.nmrPiece = new System.Windows.Forms.NumericUpDown();
            this.cmbChooseMain = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmainid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(109, 68);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(202, 20);
            this.txtFoodName.TabIndex = 0;
            // 
            // txtFoodPriceMasked
            // 
            this.txtFoodPriceMasked.Location = new System.Drawing.Point(110, 102);
            this.txtFoodPriceMasked.Mask = "00000.00";
            this.txtFoodPriceMasked.Name = "txtFoodPriceMasked";
            this.txtFoodPriceMasked.Size = new System.Drawing.Size(202, 20);
            this.txtFoodPriceMasked.TabIndex = 1;
            this.txtFoodPriceMasked.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Fiyatı:";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(236, 150);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 3;
            this.btnAddFood.Text = "Ekle";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cmbSelectFood
            // 
            this.cmbSelectFood.FormattingEnabled = true;
            this.cmbSelectFood.Location = new System.Drawing.Point(585, 71);
            this.cmbSelectFood.Name = "cmbSelectFood";
            this.cmbSelectFood.Size = new System.Drawing.Size(278, 21);
            this.cmbSelectFood.TabIndex = 4;
            this.cmbSelectFood.SelectedIndexChanged += new System.EventHandler(this.cmbSelectFood_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(461, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Seç:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(788, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblfoodid
            // 
            this.lblfoodid.AutoSize = true;
            this.lblfoodid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfoodid.Location = new System.Drawing.Point(845, 51);
            this.lblfoodid.Name = "lblfoodid";
            this.lblfoodid.Size = new System.Drawing.Size(17, 17);
            this.lblfoodid.TabIndex = 2;
            this.lblfoodid.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(744, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ürün ID:";
            // 
            // radioGram
            // 
            this.radioGram.AutoSize = true;
            this.radioGram.Location = new System.Drawing.Point(585, 219);
            this.radioGram.Name = "radioGram";
            this.radioGram.Size = new System.Drawing.Size(50, 17);
            this.radioGram.TabIndex = 6;
            this.radioGram.TabStop = true;
            this.radioGram.Text = "Gram";
            this.radioGram.UseVisualStyleBackColor = true;
            this.radioGram.CheckedChanged += new System.EventHandler(this.radioGram_CheckedChanged);
            // 
            // radioPiece
            // 
            this.radioPiece.AutoSize = true;
            this.radioPiece.Location = new System.Drawing.Point(585, 246);
            this.radioPiece.Name = "radioPiece";
            this.radioPiece.Size = new System.Drawing.Size(47, 17);
            this.radioPiece.TabIndex = 6;
            this.radioPiece.TabStop = true;
            this.radioPiece.Text = "Adet";
            this.radioPiece.UseVisualStyleBackColor = true;
            this.radioPiece.CheckedChanged += new System.EventHandler(this.radioPiece_CheckedChanged);
            // 
            // txtMaskedGram
            // 
            this.txtMaskedGram.Enabled = false;
            this.txtMaskedGram.Location = new System.Drawing.Point(670, 216);
            this.txtMaskedGram.Mask = "000000.000";
            this.txtMaskedGram.Name = "txtMaskedGram";
            this.txtMaskedGram.Size = new System.Drawing.Size(193, 20);
            this.txtMaskedGram.TabIndex = 7;
            this.txtMaskedGram.ValidatingType = typeof(int);
            // 
            // nmrPiece
            // 
            this.nmrPiece.Enabled = false;
            this.nmrPiece.Location = new System.Drawing.Point(670, 243);
            this.nmrPiece.Name = "nmrPiece";
            this.nmrPiece.Size = new System.Drawing.Size(192, 20);
            this.nmrPiece.TabIndex = 8;
            // 
            // cmbChooseMain
            // 
            this.cmbChooseMain.FormattingEnabled = true;
            this.cmbChooseMain.Location = new System.Drawing.Point(585, 102);
            this.cmbChooseMain.Name = "cmbChooseMain";
            this.cmbChooseMain.Size = new System.Drawing.Size(278, 21);
            this.cmbChooseMain.TabIndex = 4;
            this.cmbChooseMain.SelectedIndexChanged += new System.EventHandler(this.cmbChooseMain_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(461, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ana Ürün Seç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(745, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ürün ID:";
            // 
            // lblmainid
            // 
            this.lblmainid.AutoSize = true;
            this.lblmainid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmainid.Location = new System.Drawing.Point(846, 126);
            this.lblmainid.Name = "lblmainid";
            this.lblmainid.Size = new System.Drawing.Size(17, 17);
            this.lblmainid.TabIndex = 2;
            this.lblmainid.Text = "0";
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.nmrPiece);
            this.Controls.Add(this.txtMaskedGram);
            this.Controls.Add(this.radioPiece);
            this.Controls.Add(this.radioGram);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbChooseMain);
            this.Controls.Add(this.cmbSelectFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblmainid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblfoodid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFoodPriceMasked);
            this.Controls.Add(this.txtFoodName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AddFood";
            this.Load += new System.EventHandler(this.AddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.MaskedTextBox txtFoodPriceMasked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cmbSelectFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblfoodid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioGram;
        private System.Windows.Forms.RadioButton radioPiece;
        private System.Windows.Forms.MaskedTextBox txtMaskedGram;
        private System.Windows.Forms.NumericUpDown nmrPiece;
        private System.Windows.Forms.ComboBox cmbChooseMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmainid;
    }
}