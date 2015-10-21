using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocITApp.Forms
{
    public partial class AddClient : Form
    {
        private int distance;
        public AddClient()
        {
            InitializeComponent();
        }

        private void saveClientBtn_Click(object sender, EventArgs e)
        {
            string email = tbx_Email.Text;
            if (email.IndexOf("@") == -1 || email.IndexOf(".") == -1)
                tbx_Email.BackColor = Color.Red;
            else
                tbx_Email.BackColor = Color.Green;

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sjoerd\Documents\GitHub\Barroc-IT\BarrocITApp\BarrocITApp\BarrocITDB(N).mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    SqlCommand CmdSql = new SqlCommand("INSERT INTO tbl_clientData (c_name, c_zipcode1, c_adress1, c_place1, c_zipcode2, c_adress2, c_place2, c_contactPerson, c_contactPersonInitials, c_phoneNumber, c_faxNumber, c_email, b_bankAccountNumber, b_ledgerAccountNumber, b_limit, b_grossRevenu, b_creditBalance, b_creditworthiness, b_potentialCustomer, b_bkr) VALUES (@c_name, @c_zipcode1, @c_adress1, @c_place1, @c_zipcode2, @c_adress2, @c_place2, @c_contactPerson, @c_contactPersonInitials, @c_phoneNumber, @c_faxNumber, @c_email, @b_bankAccountNumber, @b_ledgerAccountNumber, @b_limit, @b_grossRevenu, @b_creditBalance, @b_creditworthiness, @b_potentialCustomer, @b_bkr)", conn);
                   
                    conn.Open();

                    CmdSql.Parameters.AddWithValue("@c_name", tbx_CompanyName.Text);
                    CmdSql.Parameters.AddWithValue("@c_zipcode1", tbx_Zipcode1.Text);
                    CmdSql.Parameters.AddWithValue("@c_adress1", tbx_Adress1.Text);
                    CmdSql.Parameters.AddWithValue("@c_place1", tbx_Place1.Text);
                    CmdSql.Parameters.AddWithValue("@c_zipcode2", tbx_Zipcode2.Text);
                    CmdSql.Parameters.AddWithValue("@c_adress2", tbx_Adress2.Text);
                    CmdSql.Parameters.AddWithValue("@c_place2", tbx_Place2.Text);
                    CmdSql.Parameters.AddWithValue("@c_contactPerson", tbx_ContactPerson.Text);
                    CmdSql.Parameters.AddWithValue("@c_contactPersonInitials", tbx_ContactInitials.Text);
                    CmdSql.Parameters.AddWithValue("@c_phoneNumber", tbx_Phonenumber.Text);
                    CmdSql.Parameters.AddWithValue("@c_faxNumber", tbx_FaxNumber.Text);
                    CmdSql.Parameters.AddWithValue("@c_email", tbx_Email.Text);

                    CmdSql.Parameters.AddWithValue("@b_bankAccountNumber", tbx_BankAccountNumber.Text);
                    CmdSql.Parameters.AddWithValue("@b_ledgerAccountNumber", tbx_LedgerAccountNumber.Text);
                    CmdSql.Parameters.AddWithValue("@b_limit", tbx_Limit.Text);
                    CmdSql.Parameters.AddWithValue("@b_grossRevenu", tbx_GrossRevenu.Text);
                    CmdSql.Parameters.AddWithValue("@b_creditBalance", tbx_CreditBalance.Text);
                  

                    if (Cbx_CreditWorthy.Checked == true)
                    {
                     CmdSql.Parameters.AddWithValue("@b_creditworthiness", "1");
                    }
                    if (Cbx_CreditWorthy.Checked == false)
                    {
                     CmdSql.Parameters.AddWithValue("@b_creditworthiness", "0");
                    }
                    if (Cbx_PotentialCustomer.Checked == true)
                    {
                        CmdSql.Parameters.AddWithValue("@b_potentialCustomer", "1");
                    }
                    if (Cbx_PotentialCustomer.Checked == false)
                    {
                        CmdSql.Parameters.AddWithValue("@b_potentialCustomer", "0");
                    }
                    CmdSql.Parameters.AddWithValue("@b_bkr", tbx_Bkr.Text);
                    
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
