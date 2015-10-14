using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocITApp.Forms
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }

        private void saveClientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sjoerd\Documents\GitHub\Barroc-IT\BarrocITApp\BarrocITApp\BarrocITDB.mdf;Integrated Security=True;Connect Timeout=30"))
                 {
                  SqlCommand CmdSql = new SqlCommand("INSERT INTO tbl_klantendata (company name)", conn);
                         
                   conn.Open();

                   CmdSql.Parameters.AddWithValue("company name", tbx_CompanyName.Text);
                   
                   CmdSql.ExecuteNonQuery();
                   
                   conn.Close();
                        }
             }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
