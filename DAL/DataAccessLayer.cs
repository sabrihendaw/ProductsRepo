using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace products.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        // This Constructor Inisializ the connection object 
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Server=.\SQLEXPRESS;Database=product_DB;Integrated Security=true");
        }
        // Method to open the connection
        public void Open()
        {
            if (sqlconnection.State!=ConnectionState.Open)
            {
                sqlconnection.Open();
            }
          
        }
        // Method to open the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        // Method to Read Data From Database
        public DataTable SelectData(string stored_procedure,SqlParameter[] param)
        {
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.CommandText = stored_procedure;
            sqlcm.Connection = sqlconnection;
            if (param!=null)
            {
                for(int i=0;i<param.Length;i++)
                {
                    sqlcm.Parameters.Add(param[i]);

                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //Method to Insert,Update and Delete Data From Database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcm = new SqlCommand();
            sqlcm.CommandType = CommandType.StoredProcedure;
            sqlcm.CommandText = stored_procedure;
            sqlcm.Connection = sqlconnection;
            if (param != null)
            {
                    sqlcm.Parameters.AddRange(param);               
            }
            sqlcm.ExecuteNonQuery();
        }
    }
}
