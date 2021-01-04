namespace Sardirim_UI.Formlar.Randevu
{
    partial class ReservationForm
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
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateReservation = new System.Windows.Forms.Button();
            this.dtmPickDate = new System.Windows.Forms.DateTimePicker();
            this.cmbChooseBranch = new System.Windows.Forms.ComboBox();
            this.lstChooseTable = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstChooseCustomer = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbOrderTaker = new System.Windows.Forms.ComboBox();
            this.lblStaffid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcustomer = new System.Windows.Forms.Label();
            this.lbltable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(281, 83);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(195, 20);
            this.txtSearchName.TabIndex = 1;
            this.txtSearchName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İsimle Arama";
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.Location = new System.Drawing.Point(721, 385);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(162, 23);
            this.btnCreateReservation.TabIndex = 9;
            this.btnCreateReservation.Text = "Rezervasyon Oluştur";
            this.btnCreateReservation.UseVisualStyleBackColor = true;
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click_1);
            // 
            // dtmPickDate
            // 
            this.dtmPickDate.Location = new System.Drawing.Point(212, 343);
            this.dtmPickDate.Name = "dtmPickDate";
            this.dtmPickDate.Size = new System.Drawing.Size(264, 20);
            this.dtmPickDate.TabIndex = 7;
            // 
            // cmbChooseBranch
            // 
            this.cmbChooseBranch.FormattingEnabled = true;
            this.cmbChooseBranch.Items.AddRange(new object[] {
            "Kadıköy",
            "Bebek",
            "Taksim"});
            this.cmbChooseBranch.Location = new System.Drawing.Point(212, 387);
            this.cmbChooseBranch.Name = "cmbChooseBranch";
            this.cmbChooseBranch.Size = new System.Drawing.Size(264, 21);
            this.cmbChooseBranch.TabIndex = 6;
            this.cmbChooseBranch.SelectedIndexChanged += new System.EventHandler(this.cmbChooseBranch_SelectedIndexChanged_1);
            // 
            // lstChooseTable
            // 
            this.lstChooseTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstChooseTable.FullRowSelect = true;
            this.lstChooseTable.HideSelection = false;
            this.lstChooseTable.Location = new System.Drawing.Point(497, 109);
            this.lstChooseTable.Name = "lstChooseTable";
            this.lstChooseTable.Size = new System.Drawing.Size(386, 228);
            this.lstChooseTable.TabIndex = 4;
            this.lstChooseTable.UseCompatibleStateImageBehavior = false;
            this.lstChooseTable.View = System.Windows.Forms.View.Details;
            this.lstChooseTable.SelectedIndexChanged += new System.EventHandler(this.lstChooseTable_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 39;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Masa Adı";
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Şube";
            this.columnHeader7.Width = 92;
            // 
            // lstChooseCustomer
            // 
            this.lstChooseCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstChooseCustomer.FullRowSelect = true;
            this.lstChooseCustomer.HideSelection = false;
            this.lstChooseCustomer.Location = new System.Drawing.Point(12, 109);
            this.lstChooseCustomer.Name = "lstChooseCustomer";
            this.lstChooseCustomer.Size = new System.Drawing.Size(464, 228);
            this.lstChooseCustomer.TabIndex = 5;
            this.lstChooseCustomer.UseCompatibleStateImageBehavior = false;
            this.lstChooseCustomer.View = System.Windows.Forms.View.Details;
            this.lstChooseCustomer.SelectedIndexChanged += new System.EventHandler(this.lstChooseCustomer_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 39;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Müşteri Adı";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri Soyadı";
            this.columnHeader3.Width = 92;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefon Numarası";
            this.columnHeader4.Width = 103;
            // 
            // cmbOrderTaker
            // 
            this.cmbOrderTaker.FormattingEnabled = true;
            this.cmbOrderTaker.Location = new System.Drawing.Point(212, 431);
            this.cmbOrderTaker.Name = "cmbOrderTaker";
            this.cmbOrderTaker.Size = new System.Drawing.Size(264, 21);
            this.cmbOrderTaker.TabIndex = 10;
            this.cmbOrderTaker.SelectedIndexChanged += new System.EventHandler(this.cmbOrderTaker_SelectedIndexChanged);
            // 
            // lblStaffid
            // 
            this.lblStaffid.AutoSize = true;
            this.lblStaffid.Location = new System.Drawing.Point(483, 438);
            this.lblStaffid.Name = "lblStaffid";
            this.lblStaffid.Size = new System.Drawing.Size(0, 13);
            this.lblStaffid.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rezervasyon Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(42, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezervasyon Şube:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Rezervasyonu Alan:";
            // 
            // lblcustomer
            // 
            this.lblcustomer.AutoSize = true;
            this.lblcustomer.Location = new System.Drawing.Point(13, 89);
            this.lblcustomer.Name = "lblcustomer";
            this.lblcustomer.Size = new System.Drawing.Size(0, 13);
            this.lblcustomer.TabIndex = 12;
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.Location = new System.Drawing.Point(494, 90);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(0, 13);
            this.lbltable.TabIndex = 12;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.lbltable);
            this.Controls.Add(this.lblcustomer);
            this.Controls.Add(this.lblStaffid);
            this.Controls.Add(this.cmbOrderTaker);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.dtmPickDate);
            this.Controls.Add(this.cmbChooseBranch);
            this.Controls.Add(this.lstChooseTable);
            this.Controls.Add(this.lstChooseCustomer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ReservationForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateReservation;
        private System.Windows.Forms.DateTimePicker dtmPickDate;
        private System.Windows.Forms.ComboBox cmbChooseBranch;
        private System.Windows.Forms.ListView lstChooseTable;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView lstChooseCustomer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cmbOrderTaker;
        private System.Windows.Forms.Label lblStaffid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblcustomer;
        private System.Windows.Forms.Label lbltable;
    }
}