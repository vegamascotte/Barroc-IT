namespace BarrocITApp.Forms
{
    partial class AddMeeting
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
            this.datetime_MeetingDate = new System.Windows.Forms.DateTimePicker();
            this.datetime_StartTime = new System.Windows.Forms.DateTimePicker();
            this.datetime_EndTime = new System.Windows.Forms.DateTimePicker();
            this.tbx_ContactPerson = new System.Windows.Forms.TextBox();
            this.tbx_Location = new System.Windows.Forms.TextBox();
            this.Tbx_AttendingPersons = new System.Windows.Forms.TextBox();
            this.btn_SaveMeeting = new System.Windows.Forms.Button();
            this.lbl_MeetingDate = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.lbl_ContactPerson = new System.Windows.Forms.Label();
            this.lbl_Location = new System.Windows.Forms.Label();
            this.lbl_AttendingPersons = new System.Windows.Forms.Label();
            this.tbl_meetingsTableAdapter1 = new BarrocITApp._BarrocITDB_N_DataSet5TableAdapters.tbl_meetingsTableAdapter();
            this.SuspendLayout();
            // 
            // datetime_MeetingDate
            // 
            this.datetime_MeetingDate.Location = new System.Drawing.Point(119, 42);
            this.datetime_MeetingDate.Name = "datetime_MeetingDate";
            this.datetime_MeetingDate.Size = new System.Drawing.Size(200, 20);
            this.datetime_MeetingDate.TabIndex = 0;
            // 
            // datetime_StartTime
            // 
            this.datetime_StartTime.CustomFormat = "HH:mm";
            this.datetime_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_StartTime.Location = new System.Drawing.Point(119, 80);
            this.datetime_StartTime.Name = "datetime_StartTime";
            this.datetime_StartTime.Size = new System.Drawing.Size(200, 20);
            this.datetime_StartTime.TabIndex = 1;
            // 
            // datetime_EndTime
            // 
            this.datetime_EndTime.CustomFormat = "HH:mm";
            this.datetime_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_EndTime.Location = new System.Drawing.Point(119, 120);
            this.datetime_EndTime.Name = "datetime_EndTime";
            this.datetime_EndTime.Size = new System.Drawing.Size(200, 20);
            this.datetime_EndTime.TabIndex = 2;
            // 
            // tbx_ContactPerson
            // 
            this.tbx_ContactPerson.Location = new System.Drawing.Point(119, 165);
            this.tbx_ContactPerson.Name = "tbx_ContactPerson";
            this.tbx_ContactPerson.Size = new System.Drawing.Size(200, 20);
            this.tbx_ContactPerson.TabIndex = 3;
            // 
            // tbx_Location
            // 
            this.tbx_Location.Location = new System.Drawing.Point(119, 202);
            this.tbx_Location.Name = "tbx_Location";
            this.tbx_Location.Size = new System.Drawing.Size(200, 20);
            this.tbx_Location.TabIndex = 4;
            // 
            // Tbx_AttendingPersons
            // 
            this.Tbx_AttendingPersons.Location = new System.Drawing.Point(119, 246);
            this.Tbx_AttendingPersons.Name = "Tbx_AttendingPersons";
            this.Tbx_AttendingPersons.Size = new System.Drawing.Size(200, 20);
            this.Tbx_AttendingPersons.TabIndex = 5;
            // 
            // btn_SaveMeeting
            // 
            this.btn_SaveMeeting.Location = new System.Drawing.Point(150, 328);
            this.btn_SaveMeeting.Name = "btn_SaveMeeting";
            this.btn_SaveMeeting.Size = new System.Drawing.Size(123, 23);
            this.btn_SaveMeeting.TabIndex = 6;
            this.btn_SaveMeeting.Text = "Save Meeting";
            this.btn_SaveMeeting.UseVisualStyleBackColor = true;
            this.btn_SaveMeeting.Click += new System.EventHandler(this.btn_SaveMeeting_Click);
            // 
            // lbl_MeetingDate
            // 
            this.lbl_MeetingDate.AutoSize = true;
            this.lbl_MeetingDate.Location = new System.Drawing.Point(20, 42);
            this.lbl_MeetingDate.Name = "lbl_MeetingDate";
            this.lbl_MeetingDate.Size = new System.Drawing.Size(71, 13);
            this.lbl_MeetingDate.TabIndex = 7;
            this.lbl_MeetingDate.Text = "Meeting Date";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Location = new System.Drawing.Point(20, 80);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(51, 13);
            this.lbl_StartTime.TabIndex = 8;
            this.lbl_StartTime.Text = "Start time";
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Location = new System.Drawing.Point(20, 120);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(48, 13);
            this.lbl_EndTime.TabIndex = 9;
            this.lbl_EndTime.Text = "End time";
            // 
            // lbl_ContactPerson
            // 
            this.lbl_ContactPerson.AutoSize = true;
            this.lbl_ContactPerson.Location = new System.Drawing.Point(20, 165);
            this.lbl_ContactPerson.Name = "lbl_ContactPerson";
            this.lbl_ContactPerson.Size = new System.Drawing.Size(80, 13);
            this.lbl_ContactPerson.TabIndex = 10;
            this.lbl_ContactPerson.Text = "Contact Person";
            // 
            // lbl_Location
            // 
            this.lbl_Location.AutoSize = true;
            this.lbl_Location.Location = new System.Drawing.Point(20, 202);
            this.lbl_Location.Name = "lbl_Location";
            this.lbl_Location.Size = new System.Drawing.Size(48, 13);
            this.lbl_Location.TabIndex = 11;
            this.lbl_Location.Text = "Location";
            // 
            // lbl_AttendingPersons
            // 
            this.lbl_AttendingPersons.AutoSize = true;
            this.lbl_AttendingPersons.Location = new System.Drawing.Point(20, 246);
            this.lbl_AttendingPersons.Name = "lbl_AttendingPersons";
            this.lbl_AttendingPersons.Size = new System.Drawing.Size(93, 13);
            this.lbl_AttendingPersons.TabIndex = 12;
            this.lbl_AttendingPersons.Text = "Attending Persons";
            // 
            // tbl_meetingsTableAdapter1
            // 
            this.tbl_meetingsTableAdapter1.ClearBeforeFill = true;
            // 
            // Meetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 426);
            this.Controls.Add(this.lbl_AttendingPersons);
            this.Controls.Add(this.lbl_Location);
            this.Controls.Add(this.lbl_ContactPerson);
            this.Controls.Add(this.lbl_EndTime);
            this.Controls.Add(this.lbl_StartTime);
            this.Controls.Add(this.lbl_MeetingDate);
            this.Controls.Add(this.btn_SaveMeeting);
            this.Controls.Add(this.Tbx_AttendingPersons);
            this.Controls.Add(this.tbx_Location);
            this.Controls.Add(this.tbx_ContactPerson);
            this.Controls.Add(this.datetime_EndTime);
            this.Controls.Add(this.datetime_StartTime);
            this.Controls.Add(this.datetime_MeetingDate);
            this.Name = "Meetings";
            this.Text = "Meetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetime_MeetingDate;
        private System.Windows.Forms.DateTimePicker datetime_StartTime;
        private System.Windows.Forms.DateTimePicker datetime_EndTime;
        private System.Windows.Forms.TextBox tbx_ContactPerson;
        private System.Windows.Forms.TextBox tbx_Location;
        private System.Windows.Forms.TextBox Tbx_AttendingPersons;
        private System.Windows.Forms.Button btn_SaveMeeting;
        private System.Windows.Forms.Label lbl_MeetingDate;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.Label lbl_ContactPerson;
        private System.Windows.Forms.Label lbl_Location;
        private System.Windows.Forms.Label lbl_AttendingPersons;
        private _BarrocITDB_N_DataSet5TableAdapters.tbl_meetingsTableAdapter tbl_meetingsTableAdapter1;
    }
}