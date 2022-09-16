using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_MVP.Logic.Services
{
    static public class DBHelper
    {
        public static SqlCommand command;
        #region this methoud to get connection string from sql server
        private static SqlConnection getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.ServerName;
            builder.InitialCatalog = Properties.Settings.Default.DBName;
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }
        #endregion
        
        #region this methoud to make insert update delete and delete all in database in all
        public static bool excuteData(string spName , Action methoud)
        {
            using(SqlConnection connection = getConnectionString())
            {
                try
                {
                    command = new SqlCommand(spName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //to excute methoud that contain parameters
                    methoud.Invoke();
                    //-----------------
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine(ex.ToString());
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        #endregion

        #region This methoud to get any data in table or stor procidur in database in all program
        public static DataTable getData(string spName, Action methoud)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = getConnectionString())
            {
                try
                {
                    command = new SqlCommand(spName, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    //to excute methoud that contain parameters
                    methoud.Invoke();
                    //-----------------
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(table);
                    dataAdapter.Dispose();
                    connection.Close(); 
                }
                catch (Exception ex)
                {
                    connection.Close();
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
                return table;
            }
        }
        #endregion
    }
}
