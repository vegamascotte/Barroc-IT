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

namespace BarrocITApp
{
    public partial class EditClientForm : Form
    {
        public EditClientForm()
        {
            InitializeComponent();
        }

        private void saveClientBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void EditClientForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("@Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\Users\\sjoerd\\Documents\\GitHub\\Barroc-IT\\BarrocITApp\\BarrocITApp\\BarrocITDB.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand command =
                new SqlCommand("select * from tbl_klantendata", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    //CustID.Text = (read["Customer_ID"].ToString());
                    textBox1.Text = (read["company name"].ToString());
                }
                read.Close();
            }
        }
    }
}
