using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace BarrocITApp.Forms
{
    public partial class AddMeeting : Form
    {
        public AddMeeting()
        {
            InitializeComponent();
        }

        private void btn_SaveMeeting_Click(object sender, EventArgs e)
        {
            try
            {

                //project ID is hardcoded for now.. has to be changed
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Jeebes\Documents\GitHub\Barroc-IT\BarrocITApp\BarrocITApp\BarrocITDB(N).mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    SqlCommand CmdSql = new SqlCommand("INSERT INTO tbl_meetings (p_projectID, m_date, m_startTime, m_endTime, m_contactPerson, m_location,m_attendingPersons) VALUES (@p_projectID, @m_date, @m_startTime, @m_endTime, @m_contactPerson, @m_location,@m_attendingPersons)", conn);
                    
                    conn.Open();

                    //same for the project ID here
                    CmdSql.Parameters.AddWithValue("@p_projectID", 1);
                    CmdSql.Parameters.AddWithValue("@m_date", datetime_MeetingDate.Value);
                    CmdSql.Parameters.AddWithValue("@m_startTime", datetime_StartTime.Value);
                    CmdSql.Parameters.AddWithValue("@m_endTime", datetime_EndTime.Value);
                    CmdSql.Parameters.AddWithValue("@m_contactPerson", tbx_ContactPerson.Text);
                    CmdSql.Parameters.AddWithValue("@m_location", tbx_Location.Text);
                    CmdSql.Parameters.AddWithValue("@m_attendingPersons", tbx_AttendingPersons.Text);
                    

                    CmdSql.ExecuteNonQuery();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
