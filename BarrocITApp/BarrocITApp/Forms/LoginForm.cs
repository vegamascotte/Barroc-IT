using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarrocITApp
{
    public enum Role { Finance, Sales, Development}
    

    public partial class LoginForm : Form
    {
        private Role role;
        private DBHandler dbHandler = new DBHandler();

        public LoginForm()
        {
            InitializeComponent();
            dbHandler.Init();
        }
        //Load of form
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
        //Errorhandeling of the Null input
        #region Errorhandeling PSW_USER
        private bool UsernameEmpty()
        {
            if (tb_username.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tb_username, "Field cannot be empty!");
                return false;
            }
            return true;
        }
        private bool PasswordEmpty()
        {
            if (tb_password.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tb_password, "Field cannot be empty!");
                return false;
            }
            return true;
        }
        #endregion
        //LoginBtn 
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UsernameEmpty() && PasswordEmpty())
            {
                if (dbHandler.CheckLoginData(tb_username.Text, tb_password.Text, ref role))
                {
                    this.Hide();

                    MainForm form2 = new MainForm(role);
                    form2.ShowDialog();

                    this.Close();
                }

            }
        }       
    }
}
