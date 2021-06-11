
using Oracle.ManagedDataAccess.Client;
using System;

namespace OracleReader
{
    class Program
    {
        ConDB _db;
        static void Main(string[] args)
        {
        
            ConDB.db.ConnectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST =(ADDRESS = (PROTOCOL = TCP)(HOST = '')(PORT = '')))(CONNECT_DATA =(SERVICE_NAME ='' ))); Persist Security Info = True; User ID ='' ; Password ='' ;";
            ConDB.db.Open();
            int UserIDCount = 0;
            string sql = "";
            using (OracleDataReader reader = new OracleCommand(sql, ConDB.db).ExecuteReader())
            {
                while (reader.Read())
                {
                    //select Count(Columnname) as EmpCount from Table
                    UserIDCount = int.Parse(reader["EmpCount"].ToString());
                }
            }
            ConDB.db.Close();
          
        }
    }
}
