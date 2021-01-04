namespace Sardirim_UI.Formlar.Mutfak
{
    partial class FoodStatusCheck
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
            this.lstFoodStatuesCheck = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            this.lstFoodStatuesCheck.Location = new System.Drawing.Point(12, 12);
            this.lstFoodStatuesCheck.Name = "lstFoodStatuesCheck";
            this.lstFoodStatuesCheck.Size = new System.Drawing.Size(896, 513);
            this.lstFoodStatuesCheck.TabIndex = 7;
            this.lstFoodStatuesCheck.UseCompatibleStateImageBehavior = false;
            this.lstFoodStatuesCheck.View = System.Windows.Forms.View.Details;
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
            this.columnHeader3.Width = 208;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Siparişi Alan";
            this.columnHeader4.Width = 220;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Yemeğin Durumu";
            this.columnHeader5.Width = 197;
            // 
            // FoodStatusCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 553);
            this.Controls.Add(this.lstFoodStatuesCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodStatusCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FoodStatusCheck";
            this.Load += new System.EventHandler(this.FoodStatusCheck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstFoodStatuesCheck;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}