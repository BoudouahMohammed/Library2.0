using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_MVP.Logic.Services
{
    static class CountryService
    {
        #region A functions that connects to the database, adding, modifying, deleting, deleting all, getAllData and CountrygetMaxID
        /*******************************-- Insert --*******************************/
        public static bool countryInsert(int id, string name)
        {
            return DBHelper.excuteData("countryInsert", () => countryParameterInsert(id, name, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void countryParameterInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /*******************************-- Update --*******************************/
        public static bool countryUpdate(int id, string name)
        {
            return DBHelper.excuteData("countryUpdate", () => countryParameterUpdatet(id, name, DBHelper.command));
        }
        //this methoud to add Update paramter into stord prosedure
        private static void countryParameterUpdatet(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /*******************************-- Delete --*******************************/
        public static bool countryDelete(int id)
        {
            return DBHelper.excuteData("countryDelete", () => countryParameterDelete(id, DBHelper.command));
        }
        //this methoud to add Delete paramter into stord prosedure
        private static void countryParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
        }
        /*******************************-- Delete All --*******************************/
        public static bool countryDeleteAll()
        {
            return DBHelper.excuteData("countryDeleteAll", () => countryParameterDeleteAll());
        }
        //this methoud to add Delete All paramter into stord prosedure
        private static void countryParameterDeleteAll() { }

        /*******************************-- Get All Data --*******************************/
        public static DataTable getAllData()
        {
            return DBHelper.getData("countryGetAll", () => { });
        }
        /*******************************-- Country Get Get Max Id --*******************************/
        public static DataTable CountrygetMaxID()
        {
            return DBHelper.getData("countryGetMaxId", () => { });
        }
        #endregion
    }
}
