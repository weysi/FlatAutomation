using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatAutomation.Helpers
{
    class SqlHelper
    {
       private SqlConnection conn { get; set; }
        private string connectionString { get; set; }
        public SqlHelper()
        {
            connectionString = "Server=WISSEN;Database=FlatAutomation;Integrated Security=true";
            conn = new SqlConnection(connectionString);
        }

        public DataTable FillDataTable(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(query,conn);
            adp.Fill(dt);
            return dt;

        } 
        public void ExecuteProc(string proc,params SqlParameter[] p)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = proc;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
         

        }
        public void ExecuteCommand(string query)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
          
        }
    }
}
