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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //Load of form
        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
        //Errorhandeling of the Null input
        #region Errorhandeling PSW_USER
        private bool UsernameEmpty()
        {
            if (UssernameTbx.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(UssernameTbx, "Field cannot be empty!");
                return false;
            }
            return true;
        }
        private bool PasswordEmpty()
        {
            if (PasswordTbx.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(PasswordTbx, "Field cannot be empty!");
                return false;
            }
            return true;
        }
        #endregion
        //LoginBtn 
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UsernameEmpty();
            PasswordEmpty();
        }
        //Hash to compare values with database password
        public static String GetMD5Hash(String TextToHash)
        {
            //Check wether data was passed
            if ((TextToHash == null) || (TextToHash.Length == 0))
            {
                return String.Empty;
            }

            //Calculate MD5 hash. This requires that the string is splitted into a byte[].
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);

            //Convert result back to string.
            return System.BitConverter.ToString(result);
        }
    }
}
