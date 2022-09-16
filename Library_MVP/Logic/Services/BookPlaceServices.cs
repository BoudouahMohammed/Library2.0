using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    static class BookPlaceServices
    {
        #region A functions that connects to the database, adding, modifying, deleting, deleting all, getAllData and CountrygetMaxID
        /*******************************-- Book Place Insert --*******************************/
        public static bool bookPlaceInsert(int id, string name)
        {
            return DBHelper.excuteData("placeInsert", () => bookPlaceParameterInsert(id, name, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void bookPlaceParameterInsert(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /*******************************-- Book Place Update --*******************************/
        public static bool bookPlaceUpdate(int id, string name)
        {
            return DBHelper.excuteData("placeUpdate", () => bookPlaceParameterUpdatet(id, name, DBHelper.command));
        }
        //this methoud to add Update paramter into stord prosedure
        private static void bookPlaceParameterUpdatet(int id, string name, SqlCommand command)
        {
            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
        /*******************************-- Book Place Delete --*******************************/
        public static bool bookPlaceDelete(int id)
        {
            return DBHelper.excuteData("placeDelete", () => bookPlaceParameterDelete(id, DBHelper.command));
        }
        //this methoud to add Delete paramter into stord prosedure
        private static void bookPlaceParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@ID", SqlDbType.Int).Value = id;
        }
        /*******************************-- Book Place Delete All --*******************************/
        public static bool bookPlaceDeleteAll()
        {
            return DBHelper.excuteData("placeDeleteAll", () => bookPlaceParameterDeleteAll());
        }
        //this methoud to add Delete All paramter into stord prosedure
        private static void bookPlaceParameterDeleteAll() { }
        /*******************************-- Book Place Get All Data --*******************************/
        public static DataTable bookPlaceGetAllData()
        {
            return DBHelper.getData("placeGetAll", () => { });
        }
        /*******************************-- Book Place Get Max Id --*******************************/
        public static DataTable bookPlacegetMaxID()
        {
            return DBHelper.getData("placeGetMaxId", () => { });
        }
        #endregion
    }
}
