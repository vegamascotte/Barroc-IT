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
    public class DBHandler
    {
        private SqlConnection con;
        
        public void Init()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\sjoerd\Documents\GitHub\Barroc-IT\BarrocITApp\BarrocITApp\BarrocITDB(N).mdf;Integrated Security=True;Connect Timeout=30");
        }

        public bool TestConnection()
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

        public bool Connect()
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

        public bool Disconnect()
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

        public DataTable FillDT(string query)
        {
            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, GetCon());
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            
            Disconnect();

            return dt;
        }

        public SqlConnection GetCon()
        {
            return con;
        }

        private bool IsOpen()
        {
            return con.State == ConnectionState.Open;
        }

        public bool CheckLoginData(string username, string password, ref Role role)
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

        public void InsertProject(object[] datas)
        {
        }

        public void InsertRow(string table, string values)
        {
            Init();
            SqlCommand cmd = new SqlCommand();
            //SqlDataReader reader;
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO " + table + " VALUES" + "(" + values + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}