using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    static class AuthorService
    {
        #region A functions that connects to the database, adding, modifying, deleting, deleting all, getAllData and CountrygetMaxID
        /*******************************-- Author Insert --*******************************/
        public static bool autherInsert(int id, string name, string _date, int idAuther)
        {
            return DBHelper.excuteData("authorInsert", () => authorParameterInsert(id, name, _date, idAuther, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void authorParameterInsert(int id, string name, string _date, int idcountry, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = _date;
            command.Parameters.Add("@idCountry", SqlDbType.Int).Value = idcountry;
        }

        /*******************************-- Author Update --*******************************/
        public static bool autherUpdate(int id, string name, string _date, int idAuther)
        {
            return DBHelper.excuteData("authorUpdate", () => authorParameterUpdate(id, name, _date, idAuther, DBHelper.command));
        }
        //this methoud to add Update paramter into stord prosedure
        private static void authorParameterUpdate(int id, string name, string _date, int idcountry, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = _date;
            command.Parameters.Add("@idCountry", SqlDbType.Int).Value = idcountry;
        }

        /*******************************-- Author Delete --*******************************/
        public static bool authorDelete(int id)
        {
            return DBHelper.excuteData("authorDelete", () => authorParameterDelete(id, DBHelper.command));
        }
        //this methoud to add Delete paramter into stord prosedure
        private static void authorParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        /*******************************-- Auther Delete All --*******************************/
        public static bool autherDeleteAll()
        {
            return DBHelper.excuteData("authorDeleteAll", () => autherParameterDeleteAll());
        }
        //this methoud to add Delete All paramter into stord prosedure
        private static void autherParameterDeleteAll() { }
        /*******************************-- Author Get All Data --*******************************/
        public static DataTable getAllData()
        {
            return DBHelper.getData("authorGetAll", () => { });
        }
        /*******************************-- Author Get All Data Country --*******************************/
        public static DataTable getAllDataCMB()
        {
            return DBHelper.getData("authorcountryGetAllCMB", () => { });
        }

        /*******************************-- Author Get Max ID --*******************************/
        public static DataTable autherGetMaxId()
        {
            return DBHelper.getData("authorGetMaxId", () => { });
        }
        #endregion
    }
}
