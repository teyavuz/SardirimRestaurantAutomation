namespace Sardirim_UI.Formlar.Stok
{
    partial class AccountingForm
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
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.rtxtComment = new System.Windows.Forms.RichTextBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstAccountingShow = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rdbGelir = new System.Windows.Forms.RadioButton();
            this.rdbGider = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cmbSource
            // 
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(155, 438);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(185, 21);
            this.cmbSource.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(155, 483);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(185, 20);
            this.txtValue.TabIndex = 2;
            // 
            // rtxtComment
            // 
            this.rtxtComment.Location = new System.Drawing.Point(432, 435);
            this.rtxtComment.Name = "rtxtComment";
            this.rtxtComment.Size = new System.Drawing.Size(236, 80);
            this.rtxtComment.TabIndex = 3;
            this.rtxtComment.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(674, 467);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yorum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kaynak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tutar";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(35, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 65);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gider Oluştur";
            // 
            // lstAccountingShow
            // 
            this.lstAccountingShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstAccountingShow.HideSelection = false;
            this.lstAccountingShow.Location = new System.Drawing.Point(13, 12);
            this.lstAccountingShow.Name = "lstAccountingShow";
            this.lstAccountingShow.Size = new System.Drawing.Size(894, 376);
            this.lstAccountingShow.TabIndex = 9;
            this.lstAccountingShow.UseCompatibleStateImageBehavior = false;
            this.lstAccountingShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Kaynak";
            this.columnHeader8.Width = 127;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Kaynak Yorum";
            this.columnHeader9.Width = 274;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tutar";
            this.columnHeader10.Width = 98;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Faktör";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Ek Yorum";
            this.columnHeader12.Width = 269;
            // 
            // rdbGelir
            // 
            this.rdbGelir.AutoSize = true;
            this.rdbGelir.Location = new System.Drawing.Point(360, 441);
            this.rdbGelir.Name = "rdbGelir";
            this.rdbGelir.Size = new System.Drawing.Size(46, 17);
            this.rdbGelir.TabIndex = 10;
            this.rdbGelir.TabStop = true;
            this.rdbGelir.Text = "Gelir";
            this.rdbGelir.UseVisualStyleBackColor = true;
            this.rdbGelir.CheckedChanged += new System.EventHandler(this.rdbGelir_CheckedChanged);
            // 
            // rdbGider
            // 
            this.rdbGider.AutoSize = true;
            this.rdbGider.Location = new System.Drawing.Point(360, 475);
            this.rdbGider.Name = "rdbGider";
            this.rdbGider.Size = new System.Drawing.Size(50, 17);
            this.rdbGider.TabIndex = 10;
            this.rdbGider.TabStop = true;
            this.rdbGider.Text = "Gider";
            this.rdbGider.UseVisualStyleBackColor = true;
            this.rdbGider.CheckedChanged += new System.EventHandler(this.rdbGider_CheckedChanged);
            // 
            // AccountingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.rdbGider);
            this.Controls.Add(this.rdbGelir);
            this.Controls.Add(this.lstAccountingShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtComment);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AccountingForm";
            this.Load += new System.EventHandler(this.AccountingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.RichTextBox rtxtComment;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstAccountingShow;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.RadioButton rdbGelir;
        private System.Windows.Forms.RadioButton rdbGider;
    }
}