namespace Sardirim_UI.Formlar.Randevu
{
    partial class OrderForm
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
            this.lstChooseRes = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblOrderID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpid = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstChooseRes
            // 
            this.lstChooseRes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstChooseRes.FullRowSelect = true;
            this.lstChooseRes.HideSelection = false;
            this.lstChooseRes.Location = new System.Drawing.Point(12, 54);
            this.lstChooseRes.Name = "lstChooseRes";
            this.lstChooseRes.Size = new System.Drawing.Size(295, 412);
            this.lstChooseRes.TabIndex = 0;
            this.lstChooseRes.UseCompatibleStateImageBehavior = false;
            this.lstChooseRes.View = System.Windows.Forms.View.Details;
            this.lstChooseRes.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "OrderID";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Masa";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(12, 38);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 13);
            this.lblOrderID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sipariş Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürünler:";
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Location = new System.Drawing.Point(401, 35);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(0, 13);
            this.lblpid.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(147, 73);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(232, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblpid);
            this.groupBox1.Location = new System.Drawing.Point(325, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 172);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.lstChooseRes);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstChooseRes;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}