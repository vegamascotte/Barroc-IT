using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarrocITApp
{
    class Utility
    {
        private static string illegalChars = "!@#$%€"; //TODO : Add all illegal char (not urgent)

        //public static Table CombineTables(Table tableA, Table tableB, string name, string sqlCmdInsert, string sqlCmdUpdate, string sqlCmdUpdateCondition)
        //{
        //    Column[] columns = new Column[tableA.columns.Count() + tableB.columns.Count()];


        //    for(int i = 0; i < tableA.columns.Count(); i++)
        //    {
        //        columns[i] = tableA.columns[i];
        //    }
        //    for(int i = tableA.columns.Count(); i <tableB.columns.Count(); i++)
        //    {
        //        columns[i] = tableB.columns[i];
        //    }


        //    //return new Table(columns, name, sqlCmdInsert, );
        //    return null;
        //}

        public static bool CheckSqlString(string s, int minLenght, int maxLenght)
        {
            s.Trim();
            return s.Count() >= minLenght && s.Count() <= maxLenght && CheckForIllegalChars(s); 
        }

        private static bool CheckForIllegalChars(string s)
        {
            for(int i = 0; i < s.Count(); i++)
            {
                for(int j = 0; j < illegalChars.Count(); j++)
                {
                    if (s[i] == illegalChars[j])
                        return false;
                }
            }

            return true;
        }
    }
}
