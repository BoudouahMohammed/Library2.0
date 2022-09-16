using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    static class DarNacherService
    {
        #region A functions that connects to the database, adding, modifying, deleting, deleting all, getAllData and CountrygetMaxID
        /*******************************-- Dar Nacher Insert --*******************************/
        public static bool darNacherInsert(int id, string name, int idAuther)
        {
            return DBHelper.excuteData("darNacherInsert", () => darNacherParameterInsert(id, name, idAuther, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void darNacherParameterInsert(int id, string name, int idcountry, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@idCountry", SqlDbType.Int).Value = idcountry;
        }
        /*******************************-- Dar Nacher Update --*******************************/
        public static bool darNacherUpdate(int id, string name, int idAuther)
        {
            return DBHelper.excuteData("darNacherUpdate", () => darNacherParameterUpdate(id, name, idAuther, DBHelper.command));
        }
        //this methoud to add Update paramter into stord prosedure
        private static void darNacherParameterUpdate(int id, string name, int idcountry, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@idCountry", SqlDbType.Int).Value = idcountry;
        }

        /*******************************-- Dar Nacher Delete --*******************************/
        public static bool darNacherDelete(int id)
        {
            return DBHelper.excuteData("darNacherDelete", () => darNacherParameterDelete(id, DBHelper.command));
        }
        //this methoud to add Delete paramter into stord prosedure
        private static void darNacherParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        /*******************************-- Dar Nacher Delete All --*******************************/
        public static bool darNacherDeleteAll()
        {
            return DBHelper.excuteData("dar_NashrDeleteAll", () => darNacherParameterDeleteAll());
        }
        //this methoud to add Delete All paramter into stord prosedure
        private static void darNacherParameterDeleteAll() { }
        /*******************************-- Dar Nacher Get All Data --*******************************/
        public static DataTable darNachergetAllData()
        {
            return DBHelper.getData("dar_NashrGetAll", () => { });
        }
        /*******************************-- Dar Nacher Get All Data Country --*******************************/
        public static DataTable darNachergetAllDataCMB()
        {
            return DBHelper.getData("dar_NashrauthorcountryGetAllCMB", () => { });
        }
        /*******************************-- Dar Nacher Get Max ID --*******************************/
        public static DataTable darNacherGetMaxId()
        {
            return DBHelper.getData("dar_NashrGetMaxId", () => { });
        }
        #endregion
    }
}
