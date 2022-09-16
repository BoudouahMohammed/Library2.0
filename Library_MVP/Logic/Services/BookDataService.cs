using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Services
{
    class BookDataService
    {
        #region Insert Update Delete DeleteAll
        /*******************************-- Book Insert --*******************************/
        public static bool bookInsert(int id, string name, int idCategory, int idAuthor, int idcountry, int idDarNacher,
            string subCat, string date, int PagesNumber, int idPlace, string statuBook, decimal price, string note)
        {
            return DBHelper.excuteData("bookInsert", () => bookParameterInsert(id, name, idCategory, idAuthor, idcountry, idDarNacher,
            subCat, date, PagesNumber, idPlace, statuBook, price, note, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void bookParameterInsert(int id, string name, int idCategory, int idAuthor, int idcountry, int idDarNacher, 
            string subCat, string date, int PagesNumber, int idPlace, string statuBook,decimal price, string note,  SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@idCategry", SqlDbType.Int).Value = idCategory;
            command.Parameters.Add("@idAuthor", SqlDbType.Int).Value = idAuthor;
            command.Parameters.Add("@idCountry", SqlDbType.Int).Value = idcountry;
            command.Parameters.Add("@idDArNacher", SqlDbType.Int).Value = idDarNacher;
            command.Parameters.Add("@Sub_Cat", SqlDbType.NVarChar).Value = subCat;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@PagesNumber", SqlDbType.Int).Value = PagesNumber;
            command.Parameters.Add("@Place_ID", SqlDbType.Int).Value = idPlace;
            command.Parameters.Add("@Book_Statu", SqlDbType.NVarChar).Value = statuBook;
            command.Parameters.Add("@Book_Price", SqlDbType.Real).Value = price;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = note;
        }
        /*******************************-- Book Update --*******************************/
        public static bool bookUpdate(int id, string name, int idCategory, int idAuthor, int idcountry, int idDarNacher,
            string subCat, string date, int PagesNumber, int idPlace, string statuBook, decimal price, string note)
        {
            return DBHelper.excuteData("bookUpdate", () => bookParameterUpdate(id, name, idCategory, idAuthor, idcountry, idDarNacher,
            subCat, date, PagesNumber, idPlace, statuBook, price, note, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void bookParameterUpdate(int id, string name, int idCategory, int idAuthor, int idcountry, int idDarNacher,
            string subCat, string date, int PagesNumber, int idPlace, string statuBook, decimal price, string note, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@idCategry", SqlDbType.Int).Value = idCategory;
            command.Parameters.Add("@idAuthor", SqlDbType.Int).Value = idAuthor;
            command.Parameters.Add("@idCountry", SqlDbType.Int).Value = idcountry;
            command.Parameters.Add("@idDArNacher", SqlDbType.Int).Value = idDarNacher;
            command.Parameters.Add("@Sub_Cat", SqlDbType.NVarChar).Value = subCat;
            command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
            command.Parameters.Add("@PagesNumber", SqlDbType.Int).Value = PagesNumber;
            command.Parameters.Add("@Place_ID", SqlDbType.Int).Value = idPlace;
            command.Parameters.Add("@Book_Statu", SqlDbType.NVarChar).Value = statuBook;
            command.Parameters.Add("@Book_Price", SqlDbType.Real).Value = price;
            command.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = note;
        }
        /*******************************-- Book Delete --*******************************/
        public static bool bookDelete(int id)
        {
            return DBHelper.excuteData("bookDelete", () => bookParameterDelete(id, DBHelper.command));
        }
        //this methoud to add insert paramter into stord prosedure
        private static void bookParameterDelete(int id, SqlCommand command)
        {
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        /*******************************-- Book DeleteAll --*******************************/
        public static bool bookDeleteAll()
        {
            return DBHelper.excuteData("bookDeleteAll", () => bookParameterDeleteAll());
        }
        //this methoud to add insert paramter into stord prosedure
        private static void bookParameterDeleteAll() { }
        #endregion

        #region Fill Combobox
        /*******************************-- Book Get All Data Country In ComboBox --*******************************/
        public static DataTable bookgetAllDataCountryCMB()
        {
            return DBHelper.getData("bookCountryGetAllCMB", () => { });
        }
        /*******************************-- Book Get All Data Dar Nacher In ComboBox --*******************************/
        public static DataTable bookgetAllDataDarNacherCMB()
        {
            return DBHelper.getData("bookDarNacherGetAllCMB", () => { });
        }
        /*******************************-- Book Get All Data Dar Nacher In ComboBox --*******************************/
        public static DataTable bookgetAllCategoryCMB()
        {
            return DBHelper.getData("bookCategoryGetAllCMB", () => { });
        }
        /*******************************-- Book Get All Place In ComboBox --*******************************/
        public static DataTable bookgetAllPlaceCMB()
        {
            return DBHelper.getData("bookPlacesGetAllCMB", () => { });
        }
        /*******************************-- Book Get All Place In ComboBox --*******************************/
        public static DataTable bookgetAllAuthorCMB()
        {
            return DBHelper.getData("bookAuthorGetAllCMB", () => { });
        }
        /*******************************-- Book Get Max ID --*******************************/
        #endregion
        public static DataTable bookgetMaxId()
        {
            return DBHelper.getData("bookGetMaxId", () => { });
        }
    }
}
