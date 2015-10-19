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
        private int distance;
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
                    SqlCommand CmdSql = new SqlCommand("INSERT INTO tbl_klantendata (companyName, contactPerson, zipcode1, zipcode2, adress1, adress2, place1, place2, initials, phoneNumber, faxNumber, email, appointmentDay, lastContactDate, nextAction, salePercentage, bankAccountNumber, creditBalance, numberOfInvoices, grossRevenu, limit, ledgerAccountNumber, taxcode, openProjects, applications, hardware, operatingSystem, appointments, internalContactPerson) VALUES (@companyName,@contactPerson,@zipcode1,@zipcode2,@adress1,@adress2,@place1,@place2,@initials,@phoneNumber,@faxNumber,@email,@appointmentDay,@lastContactDate,@nextAction,@salePercentage,@bankAccountNumber,@creditBalance,@numberOfInvoices,@grossRevenu,@limit,@ledgerAccountNumber,@taxcode,@openProjects,@applications,@hardware,@operatingSystem,@appointments,@internalContactPerson)", conn);

                    conn.Open();
                    //clean this code after dbhandler
                    if (true)
                    {
                        CmdSql.Parameters.AddWithValue("@companyName", tbx_CompanyName.Text);
                    }
                    CmdSql.Parameters.AddWithValue("@contactPerson", tbx_ContactPerson.Text);
                    CmdSql.Parameters.AddWithValue("@zipcode1", tbx_Zipcode1.Text);
                    CmdSql.Parameters.AddWithValue("@zipcode2", tbx_Zipcode2.Text);
                    CmdSql.Parameters.AddWithValue("@adress1", tbx_Adress1.Text);
                    CmdSql.Parameters.AddWithValue("@adress2", tbx_Adress2.Text);
                    CmdSql.Parameters.AddWithValue("@place1", tbx_Place1.Text);
                    CmdSql.Parameters.AddWithValue("@place2", tbx_Place2.Text);
                    CmdSql.Parameters.AddWithValue("@initials", tbx_Initials.Text);
                    CmdSql.Parameters.AddWithValue("@phoneNumber", tbx_Phonenumber.Text);
                    CmdSql.Parameters.AddWithValue("@faxNumber", tbx_FaxNumber.Text);
                    CmdSql.Parameters.AddWithValue("@email", tbx_Email.Text);
                    // CmdSql.Parameters.AddWithValue("@potential")
                    CmdSql.Parameters.AddWithValue("@appointmentDay", datetime_ApointmentDay.Value);
                    CmdSql.Parameters.AddWithValue("@lastContactDate", datetime_LastContactDate.Value);
                    CmdSql.Parameters.AddWithValue("@nextAction", tbx_NextAction.Text);
                    CmdSql.Parameters.AddWithValue("@salePercentage", tbx_SalesPercentage.Text);
                    //CmdSql.Parameters.AddWithValue("creditworthy")
                    CmdSql.Parameters.AddWithValue("@bankAccountNumber", tbx_BankAccountNumber.Text);
                    CmdSql.Parameters.AddWithValue("@creditBalance", tbx_CreditBalance.Text);
                    CmdSql.Parameters.AddWithValue("@numberOfInvoices", tbx_NumberOfInvoices.Text);
                    CmdSql.Parameters.AddWithValue("@grossRevenu", tbx_GrossRevenu.Text);
                    CmdSql.Parameters.AddWithValue("@limit", tbx_Limit.Text);
                    CmdSql.Parameters.AddWithValue("@ledgerAccountNumber", tbx_LedgerAccountNumber.Text);
                    CmdSql.Parameters.AddWithValue("@taxcode", tbx_Taxcode.Text);
                    //CmdSql.Parameters.AddWithValue("maintenance contract")
                    CmdSql.Parameters.AddWithValue("@openProjects", tbx_OpenProjects.Text);
                    CmdSql.Parameters.AddWithValue("@applications", tbx_Applications.Text);
                    CmdSql.Parameters.AddWithValue("@hardware", tbx_Hardware.Text);
                    CmdSql.Parameters.AddWithValue("@operatingSystem", tbx_OpperatingSystem.Text);
                    CmdSql.Parameters.AddWithValue("@appointments", tbx_Appontments.Text);
                    CmdSql.Parameters.AddWithValue("internalContactPerson", tbx_ContactPerson.Text);

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
