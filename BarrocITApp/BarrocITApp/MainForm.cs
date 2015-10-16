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

        public MainForm()
        {
            InitializeComponent();
        }
        //Fill the datagrid on form load
        #region FormLoadData
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'barrocITDBDataSet1.tbl_klantendata' table. You can move, or remove it, as needed.
            this.tbl_klantendataTableAdapter1.Fill(this.barrocITDBDataSet1.tbl_klantendata);
            // TODO: This line of code loads data into the 'barrocITDBDataSet.tbl_klantendata' table. You can move, or remove it, as needed.
            //this.tbl_klantendataTableAdapter.Fill(this.barrocITDBDataSet.tbl_klantendata);
            // TODO: This line of code loads data into the 'barrocITDBDataSet2.tbl_projecten' table. You can move, or remove it, as needed.
            this.tbl_projectenTableAdapter.Fill(this.barrocITDBDataSet2.tbl_projecten);
            

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
            DialogResult dialog = MessageBox.Show("Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
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
