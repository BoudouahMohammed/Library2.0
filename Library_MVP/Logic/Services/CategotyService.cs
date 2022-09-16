using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_MVP.Logic.Services
{
    static class CategotyService
    {
        #region A functions that connects to the database, adding, modifying, deleting, deleting all, getAllData and CountrygetMaxID
        /*******************************-- Categoty Insert --*******************************/
        public static bool categoryInsert(int id ,string name)
        {
            return DBHelper.excuteData("categoryInsert", () => categoryParameterInsert(id, name, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void categoryParameterInsert(int id,string name,SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value  = name;
        }
        /*******************************-- Categoty Update --*******************************/
        public static bool categoryUpdate(int id, string name)
        {
            return DBHelper.excuteData("categoryUpdate", () => categoryParameterUpdatet(id, name, DBHelper.command));
        }
        //this methoud to add Update paramter into stord prosedure
        private static void categoryParameterUpdatet(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /*******************************-- Categoty Delete --*******************************/
        public static bool categoryDelete(int id)
        {
            return DBHelper.excuteData("categoryDelete", () => categoryParameterDelete(id, DBHelper.command));
        }
        //this methoud to add Delete paramter into stord prosedure
        private static void categoryParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
        }
        /*******************************-- Categoty Delete All --*******************************/
        public static bool categoryDeleteAll()
        {
            return DBHelper.excuteData("categoryDeleteAll", () => categoryParameterDeleteAll());
        }
        //this methoud to add Delete All paramter into stord prosedure
        private static void categoryParameterDeleteAll(){}
        /*******************************-- Category Get All Data --*******************************/
        public static DataTable categoryGetAllData()
        {
            return DBHelper.getData("categoryGetAll", () => { });
        }
        /*******************************-- Category Get Max Id --*******************************/
        public static DataTable categorygetMaxID()
        {
            return DBHelper.getData("categoryGetMaxId", () => { });
        }
        #endregion
    }
}
