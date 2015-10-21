namespace BarrocITApp.Forms
{
    partial class EnrollBill
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
            this.datetime_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.tbx_Price = new System.Windows.Forms.TextBox();
            this.tbx_TaxCode = new System.Windows.Forms.TextBox();
            this.tbx_InvoiceId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datetime_InvoiceDate
            // 
            this.datetime_InvoiceDate.Location = new System.Drawing.Point(69, 162);
            this.datetime_InvoiceDate.Name = "datetime_InvoiceDate";
            this.datetime_InvoiceDate.Size = new System.Drawing.Size(200, 20);
            this.datetime_InvoiceDate.TabIndex = 0;
            // 
            // tbx_Price
            // 
            this.tbx_Price.Location = new System.Drawing.Point(69, 121);
            this.tbx_Price.Name = "tbx_Price";
            this.tbx_Price.Size = new System.Drawing.Size(200, 20);
            this.tbx_Price.TabIndex = 1;
            // 
            // tbx_TaxCode
            // 
            this.tbx_TaxCode.Location = new System.Drawing.Point(69, 78);
            this.tbx_TaxCode.Name = "tbx_TaxCode";
            this.tbx_TaxCode.Size = new System.Drawing.Size(200, 20);
            this.tbx_TaxCode.TabIndex = 2;
            // 
            // tbx_InvoiceId
            // 
            this.tbx_InvoiceId.Location = new System.Drawing.Point(69, 38);
            this.tbx_InvoiceId.Name = "tbx_InvoiceId";
            this.tbx_InvoiceId.Size = new System.Drawing.Size(200, 20);
            this.tbx_InvoiceId.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EnrollBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_InvoiceId);
            this.Controls.Add(this.tbx_TaxCode);
            this.Controls.Add(this.tbx_Price);
            this.Controls.Add(this.datetime_InvoiceDate);
            this.Location = new System.Drawing.Point(248, 373);
            this.Name = "EnrollBill";
            this.Text = "EnrollBill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetime_InvoiceDate;
        private System.Windows.Forms.TextBox tbx_Price;
        private System.Windows.Forms.TextBox tbx_TaxCode;
        private System.Windows.Forms.TextBox tbx_InvoiceId;
        private System.Windows.Forms.Button button1;
    }
}