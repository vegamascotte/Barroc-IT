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
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sjoerd\Documents\GitHub\Barroc-IT\BarrocITApp\BarrocITApp\BarrocITDB(N).mdf;Integrated Security=True;Connect Timeout=30"))
            {
                SqlCommand command =
                new SqlCommand("select * from tbl_clientData", connection);
                connection.Open();

                SqlDataReader read = command.ExecuteReader();

                while (read.Read())
                {
                    //CustID.Text = (read["Customer_ID"].ToString());
                    tbx_EditCompanyName.Text = (read["c_name"].ToString());
                    tbx_EditZipcode1.Text = (read["c_zipcode1"].ToString());
                    tbx_EditAdress1.Text = (read["c_adress1"].ToString());
                    tbx_EditPlace1.Text = (read["c_place1"].ToString());
                    tbx_EditZipcode2.Text = (read["c_zipcode2"].ToString());
                    tbx_EditAdress2.Text = (read["c_adress2"].ToString());
                    tbx_EditPlace2.Text = (read["c_place2"].ToString());
                    tbx_EditContactPerson.Text = (read["c_contactPerson"].ToString());
                    tbx_EditContactInitials.Text = (read["c_contactPersonInitials"].ToString());
                    tbx_EditPhonenumber.Text = (read["c_phoneNumber"].ToString());
                    tbx_EditFaxNumber.Text = (read["c_faxNumber"].ToString());
                    tbx_EditEmail.Text = (read["c_email"].ToString());
                    tbx_EditBankAccountNumber.Text = (read["b_bankAccountNumber"].ToString());
                    tbx_EditLedgerAccountNumber.Text = (read["b_ledgerAccountNumber"].ToString());
                    tbx_EditLimit.Text = (read["b_limit"].ToString());
                    tbx_EditGrossRevenu.Text = (read["b_grossRevenu"].ToString());
                    tbx_EditCreditBalance.Text = (read["b_creditBalance"].ToString());

                    //Getting And setting checks from DB 
                    if (read["b_creditworthiness"].ToString() == "1")
                    {
                        Cbx_CreditWorthy.Checked = true;
                    }
                    if (read["b_creditworthiness"].ToString() == "0")
                    {
                        Cbx_CreditWorthy.Checked = false;
                    }

                    //Getting And setting checks from DB 
                    if (read["b_potentialCustomer"].ToString() == "1")
                    {
                        Cbx_PotentialCustomer.Checked = true;
                    }
                    if (read["b_potentialCustomer"].ToString() == "0")
                    {
                        Cbx_PotentialCustomer.Checked = false;
                    }

                    if (read["b_bkr"].ToString() == "1")
                    {
                        cbx_Bkr.Checked = true;
                    }
                    if (read["b_bkr"].ToString() == "0")
                    {
                        cbx_Bkr.Checked = false;
                    }

                    tbx_EditContactPerson.Text = (read["c_contactPerson"].ToString());


                }
                read.Close();
            }
        }

        private void btn_saveEditClient_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sjoerd\Documents\GitHub\Barroc-IT\BarrocITApp\BarrocITApp\BarrocITDB(N).mdf;Integrated Security=True;Connect Timeout=30"))
                {
                    SqlCommand CmdSql = new SqlCommand("UPDATE tbl_clientData SET c_name, c_zipcode1, c_adress1, c_place1, c_zipcode2, c_adress2, c_place2, c_contactPerson, c_contactPersonInitials, c_phoneNumber, c_faxNumber, c_email, b_bankAccountNumber, b_ledgerAccountNumber, b_limit, b_grossRevenu, b_creditBalance, b_creditworthiness, b_potentialCustomer, b_bkr VALUES @c_name, @c_zipcode1, @c_adress1, @c_place1, @c_zipcode2, @c_adress2, @c_place2, @c_contactPerson, @c_contactPersonInitials, @c_phoneNumber, @c_faxNumber, @c_email, @b_bankAccountNumber, @b_ledgerAccountNumber, @b_limit, @b_grossRevenu, @b_creditBalance, @b_creditworthiness, @b_potentialCustomer, @b_bkr", conn);

                    conn.Open();

                    CmdSql.Parameters.AddWithValue("@c_name", tbx_EditCompanyName.Text);
                    CmdSql.Parameters.AddWithValue("@c_zipcode1", tbx_EditZipcode1.Text);
                    CmdSql.Parameters.AddWithValue("@c_adress1", tbx_EditAdress1.Text);
                    CmdSql.Parameters.AddWithValue("@c_place1", tbx_EditPlace1.Text);
                    CmdSql.Parameters.AddWithValue("@c_zipcode2", tbx_EditZipcode2.Text);
                    CmdSql.Parameters.AddWithValue("@c_adress2", tbx_EditAdress2.Text);
                    CmdSql.Parameters.AddWithValue("@c_place2", tbx_EditPlace2.Text);
                    CmdSql.Parameters.AddWithValue("@c_contactPerson", tbx_EditContactPerson.Text);
                    CmdSql.Parameters.AddWithValue("@c_contactPersonInitials", tbx_EditContactInitials.Text);
                    CmdSql.Parameters.AddWithValue("@c_phoneNumber", tbx_EditPhonenumber.Text);
                    CmdSql.Parameters.AddWithValue("@c_faxNumber", tbx_EditFaxNumber.Text);
                    CmdSql.Parameters.AddWithValue("@c_email", tbx_EditEmail.Text);

                    CmdSql.Parameters.AddWithValue("@b_bankAccountNumber", tbx_EditBankAccountNumber.Text);
                    CmdSql.Parameters.AddWithValue("@b_ledgerAccountNumber", tbx_EditLedgerAccountNumber.Text);
                    CmdSql.Parameters.AddWithValue("@b_limit", tbx_EditLimit.Text);
                    CmdSql.Parameters.AddWithValue("@b_grossRevenu", tbx_EditGrossRevenu.Text);
                    CmdSql.Parameters.AddWithValue("@b_creditBalance", tbx_EditCreditBalance.Text);

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
                    if (cbx_Bkr.Checked == true)
                    {
                        CmdSql.Parameters.AddWithValue("@b_bkr", "1");

                    }
                    if (cbx_Bkr.Checked == false)
                    {
                        CmdSql.Parameters.AddWithValue("@b_bkr", "0");
                    }

                    CmdSql.ExecuteNonQuery();

                    conn.Close();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupbox_Clientdata_Enter(object sender, EventArgs e)
        {

        }
    }
}
               

