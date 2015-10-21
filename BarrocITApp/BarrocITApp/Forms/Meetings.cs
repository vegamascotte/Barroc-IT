using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocITApp.Forms
{
    public partial class Meetings : Form
    {
        public Meetings()
        {
            InitializeComponent();
        }

        private void btn_SaveMeeting_Click(object sender, EventArgs e)
        {
            DBHandler dbHandler = new DBHandler();
            dbHandler.InsertRow("tbl_meetings", "@p_projectID,@m_meetingID,@m_date,@m_startTime,@m_endTime,@m_contactPerson,@m_location,@atteningPerson");

        }
    }
}
