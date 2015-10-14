namespace BarrocITApp.Forms
{
    partial class AddProject
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
            this.groupbox_PData = new System.Windows.Forms.GroupBox();
            this.saveClientBtn = new System.Windows.Forms.Button();
            this.lbl_Pame = new System.Windows.Forms.Label();
            this.lbl_PStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_PPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox_PData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_PData
            // 
            this.groupbox_PData.Controls.Add(this.label2);
            this.groupbox_PData.Controls.Add(this.dateTimePicker2);
            this.groupbox_PData.Controls.Add(this.dateTimePicker1);
            this.groupbox_PData.Controls.Add(this.label1);
            this.groupbox_PData.Controls.Add(this.label4);
            this.groupbox_PData.Controls.Add(this.lbl_PPrice);
            this.groupbox_PData.Controls.Add(this.textBox3);
            this.groupbox_PData.Controls.Add(this.textBox4);
            this.groupbox_PData.Controls.Add(this.textBox2);
            this.groupbox_PData.Controls.Add(this.textBox1);
            this.groupbox_PData.Controls.Add(this.lbl_PStatus);
            this.groupbox_PData.Controls.Add(this.lbl_Pame);
            this.groupbox_PData.Location = new System.Drawing.Point(13, 13);
            this.groupbox_PData.Name = "groupbox_PData";
            this.groupbox_PData.Size = new System.Drawing.Size(349, 202);
            this.groupbox_PData.TabIndex = 0;
            this.groupbox_PData.TabStop = false;
            this.groupbox_PData.Text = "Project Data";
            // 
            // saveClientBtn
            // 
            this.saveClientBtn.Location = new System.Drawing.Point(287, 226);
            this.saveClientBtn.Name = "saveClientBtn";
            this.saveClientBtn.Size = new System.Drawing.Size(75, 23);
            this.saveClientBtn.TabIndex = 9;
            this.saveClientBtn.Text = "Save";
            this.saveClientBtn.UseVisualStyleBackColor = true;
            // 
            // lbl_Pame
            // 
            this.lbl_Pame.AutoSize = true;
            this.lbl_Pame.Location = new System.Drawing.Point(6, 23);
            this.lbl_Pame.Name = "lbl_Pame";
            this.lbl_Pame.Size = new System.Drawing.Size(71, 13);
            this.lbl_Pame.TabIndex = 0;
            this.lbl_Pame.Text = "Project Name";
            this.lbl_Pame.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_PStatus
            // 
            this.lbl_PStatus.AutoSize = true;
            this.lbl_PStatus.Location = new System.Drawing.Point(6, 49);
            this.lbl_PStatus.Name = "lbl_PStatus";
            this.lbl_PStatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_PStatus.TabIndex = 1;
            this.lbl_PStatus.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 20);
            this.textBox4.TabIndex = 4;
            // 
            // lbl_PPrice
            // 
            this.lbl_PPrice.AutoSize = true;
            this.lbl_PPrice.Location = new System.Drawing.Point(6, 75);
            this.lbl_PPrice.Name = "lbl_PPrice";
            this.lbl_PPrice.Size = new System.Drawing.Size(31, 13);
            this.lbl_PPrice.TabIndex = 6;
            this.lbl_PPrice.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount of Invoices";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Starting Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(110, 146);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amount of Invoices";
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.saveClientBtn);
            this.Controls.Add(this.groupbox_PData);
            this.Name = "AddProject";
            this.Text = "Add Project";
            this.groupbox_PData.ResumeLayout(false);
            this.groupbox_PData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_PData;
        private System.Windows.Forms.Label lbl_Pame;
        private System.Windows.Forms.Button saveClientBtn;
        private System.Windows.Forms.Label lbl_PStatus;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_PPrice;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}