using BarrocITApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocITApp
{
    public partial class MainForm : Form
    {
        private EnrollBill enrollBill;
        private Forms.AddClient addClient;
        private EditClientForm editClientForm;
        public string loggedInAs = "Admin";
        private Role role;
        public MainForm(Role role)
        {
            InitializeComponent();
            this.role = role;
        }
        //Fill the datagrid on form load
        #region FormLoadData
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_BarrocITDB_N_DataSet5.tbl_meetings' table. You can move, or remove it, as needed.
            this.tbl_meetingsTableAdapter.Fill(this._BarrocITDB_N_DataSet5.tbl_meetings);
            // TODO: This line of code loads data into the '_BarrocITDB_N_DataSet4.tbl_clientData' table. You can move, or remove it, as needed.
            this.tbl_clientDataTableAdapter.Fill(this._BarrocITDB_N_DataSet4.tbl_clientData);
            // TODO: This line of code loads data into the '_BarrocITDB_N_DataSet3.tbl_invoices' table. You can move, or remove it, as needed.
            this.tbl_invoicesTableAdapter.Fill(this._BarrocITDB_N_DataSet3.tbl_invoices);
            // TODO: This line of code loads data into the '_BarrocITDB_N_DataSet2.tbl_projects' table. You can move, or remove it, as needed.
            this.tbl_projectsTableAdapter1.Fill(this._BarrocITDB_N_DataSet2.tbl_projects);
            // TODO: This line of code loads data into the '_BarrocITDB_N_DataSet.tbl_projects' table. You can move, or remove it, as needed.
            this.tbl_projectsTableAdapter.Fill(this._BarrocITDB_N_DataSet.tbl_projects);

            Lbl_LogedInas.Text = "Logged is as: " + loggedInAs + " at: " + DateTime.Now.ToShortTimeString();
        }
        #endregion

        private void button10_Click(object sender, EventArgs e)
        {

            if (enrollBill != null)
            {
                enrollBill.Hide();
                enrollBill = null;
            }

            enrollBill = new Forms.EnrollBill();
            enrollBill.Show();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to close the program: " +loggedInAs + " ? ", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
	        {
		        e.Cancel = true;
	        }

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addClientOpenForm_Click(object sender, EventArgs e)
        {
            if (addClient != null)
            {
                addClient.Hide();
                addClient = null;
            }

            addClient = new Forms.AddClient();
            addClient.Show();
        }

        private void btn_editClientOpenForm_Click(object sender, EventArgs e)
        {
            if (editClientForm != null)
            {
                editClientForm.Hide();
                editClientForm = null;
            }

            editClientForm = new EditClientForm();
            editClientForm.Show();
        }
    }
}
