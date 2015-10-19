using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace BarrocITApp
{
    class DBHandler
    {
        private static SqlConnection con;
        
        public static void Init()
        {
            con = new SqlConnection(@"Data Source = (LocalDB)\v11.0; AttachDbFilename = C:\Users\admin\Desktop\BarrocITApp\BarrocITApp\BarrocITDB.mdf; Integrated Security = True; Connect Timeout = 30");
        }

        public static bool TestConnection()
        {
            if(!IsOpen())
            {
                try
                {
                    if (IsOpen())
                    {
                        con.Close();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }
            return false;        
        }

        public static bool Connect()
        {
            if(!IsOpen())
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch(SqlException e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return false;
        }

        public static bool Disconnect()
        {
            if (IsOpen())
            {
                try
                {
                    con.Close();
                    return true;
                }
                catch (Exception e)
                {

                }
            }
            return false;
        }

        public static DataTable FillDT(string query)
        {
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            
            Disconnect();

            return dt;
        }

        public static SqlConnection GetCon()
        {
            return con;
        }

        private static bool IsOpen()
        {
            return con.State == ConnectionState.Open;
        }

        public static bool CheckLoginData(string username, string password, ref Role role)
        {
            Connect();
            try
            {
                SqlDataReader dataReader = new SqlCommand("SELECT * FROM tbl_login", con).ExecuteReader();

                while (dataReader.Read())
                {
                    if (dataReader["username"].ToString().Trim() == username && dataReader["password"].ToString().Trim() == password)
                    {
                        MessageBox.Show("Login succes");

                        switch((int)dataReader["id"])
                        {
                            case 0:
                                role = Role.Development; break;
                            case 1:
                                role = Role.Finance; break;
                            case 2:
                                role = Role.Sales; break;
                        }

                        dataReader.Close();

                        return true;
                    }
                }
                dataReader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Wrong username and/or wrong password");
            return false;
        }

        public static object[] GetRow(DataTable table, int index)
        {
            return table.Rows[index].ItemArray;
        }

        public static void InsertProject(object[] datas)
        {
        }


    }
}