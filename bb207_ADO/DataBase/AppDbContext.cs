using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207_ADO.DataBase
{
    public class AppDbContext
    {
        readonly string connectionString = "Server=DESKTOP-FQ5NTQE;Database=BB207_ADO;Trusted_connection=true;Integrated security=true";
        SqlConnection sqlConnection;
        public AppDbContext()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int NonQuery(string command)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand  = new SqlCommand(command, sqlConnection);
            int result = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return result;
        }

        public DataTable Query(string query)
        {
            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query,sqlConnection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            sqlConnection.Close();
            return table;
        }


    }
}
