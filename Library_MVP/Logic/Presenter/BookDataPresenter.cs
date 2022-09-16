using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Presenter
{
    class BookDataPresenter
    {
        IBookData ibookData;
        BookDataModel bookDataModel = new BookDataModel();
        public BookDataPresenter(IBookData view)
        {
            this.ibookData = view;
        }

        #region Connect between model auther and interface auther
        private void connectBetweenModelInterface()
        {
            bookDataModel.ID = ibookData.ID;
            bookDataModel.BookName = ibookData.BookName;
            bookDataModel.CatID = ibookData.CatID;
            bookDataModel.AuthorID = ibookData.AuthorID;
            bookDataModel.CountryID = ibookData.CountryID;
            bookDataModel.DarID = ibookData.DarID;
            bookDataModel.SubCat = ibookData.SubCat;
            bookDataModel.Date = ibookData.Date;
            bookDataModel.PageNumbers = ibookData.PageNumbers;
            bookDataModel.PlaceID = ibookData.PlaceID;
            bookDataModel.BookStatu = ibookData.BookStatu;
            bookDataModel.BookPrice = ibookData.BookPrice;
            bookDataModel.Notes = ibookData.Notes;
        }
        #endregion

        #region Functions ==> AutherInsert, AutherUpdate, AutherRemove and AutherRemoveAll
        //public bool bookInsert()
        //{
        //    connectBetweenModelInterface();
        //    return BookDataService.bookInsert(bookDataModel.ID, bookDataModel.BookName, bookDataModel.CatID, bookDataModel.AuthorID, bookDataModel.CountryID, bookDataModel.DarID, bookDataModel.SubCat, bookDataModel.Date, bookDataModel.PageNumbers, bookDataModel.PlaceID, bookDataModel.BookStatu, bookDataModel.BookPrice, bookDataModel.Notes);
        //}
        //public bool bookUpdate()
        //{
        //    connectBetweenModelInterface();
        //    return BookDataService.bookUpdate(bookDataModel.ID, bookDataModel.BookName, bookDataModel.CatID, bookDataModel.AuthorID, bookDataModel.CountryID, bookDataModel.DarID, bookDataModel.SubCat, bookDataModel.Date, bookDataModel.PageNumbers, bookDataModel.PlaceID, bookDataModel.BookStatu, bookDataModel.BookPrice, bookDataModel.Notes);
        //}
        //public bool bookRemove()
        //{
        //    connectBetweenModelInterface();
        //    return BookDataService.bookDelete(bookDataModel.ID);
        //}
        //public bool bookRemoveAll()
        //{
        //    return BookDataService.bookDeleteAll();
        //}
        #endregion

        #region Functions FillCMB, AutoNumber, updateRemoveButtons and getCountAllRow
        public void FillCMBCountry()
        {
            ibookData.cmbCountry = BookDataService.bookgetAllDataCountryCMB();
            ibookData.cmbCountryDisplayMember = "Country_Name";
            ibookData.cmbCountryValueMember = "ID";
        }
        public void FillCMBDarNacher()
        {
            ibookData.cmbDarNacher = BookDataService.bookgetAllDataDarNacherCMB();
            ibookData.cmbDarNacherDisplayMember = "Dar_Name";
            ibookData.cmbNacherValueMember = "ID";
        }
        public void FillCMBCategory()
        {
            ibookData.cmbCat = BookDataService.bookgetAllCategoryCMB();
            ibookData.cmbCatDisplayMember = "Cat_Name";
            ibookData.cmbCatValueMember = "ID";
        }
        public void FillCMBPlaces()
        {
            ibookData.cmbPlace = BookDataService.bookgetAllPlaceCMB();
            ibookData.cmbPlaceDisplayMember = "Place_Name";
            ibookData.cmbPlaceValueMember = "ID";
        }
        public void FillCMBAuthor()
        {
            ibookData.cmbAuthor = BookDataService.bookgetAllAuthorCMB();
            ibookData.cmbAuthorDisplayMember = "Author_Name";
            ibookData.cmbAuthorValueMember = "ID";
        }
        public void AutoNumber()
        {
            string id = Convert.ToString(BookDataService.bookgetMaxId().Rows[0][0]);
            if (id == null || id == string.Empty)
            {
                ibookData.ID = 1;
            }
            else
            {
                ibookData.ID = Convert.ToInt32(BookDataService.bookgetMaxId().Rows[0][0]) + 1;
                ibookData.cmbAuthorSelectdIndex = 0;
            }
            vider();
            //ibookData.txbNameFocus = true;
            ibookData.btnAdd = true;
            ibookData.btnUpdate = false;
            ibookData.btnRemove = false;
            ibookData.btnRemoveAll = false;
        }
        //public void updateRemoveButtons()
        //{
        //    //ibookData.txbNameBook = true;
        //    //ibookData.btnAdd = false;
        //    //ibookData.btnRemove = true;
        //    //ibookData.btnRemoveAll = true;
        //    //ibookData.btnUpdate = true;
        //}
        //////public int getCountAllRow()
        //////{
        //////    //return DarNacherService.darNachergetAllData().Rows.Count;
        //////}
        public void vider()
        {
            ibookData.txbNameFocus = true;
            ibookData.txbNameBook = string.Empty;
            ibookData.txbSubCat = string.Empty;
            ibookData.txbStatus = string.Empty;
            ibookData.Notes = string.Empty;
            ibookData.numiriquePrice = 1;
            ibookData.numiriquePage = 1;
            ibookData.dateTime = DateTime.Now;
            ibookData.cmbAuthorSelectdIndex = 0;
            ibookData.cmbCountrySelectdIndex = 0;
            ibookData.cmbCatSelectdIndex = 0;
            ibookData.cmbPlaceSelectdIndex = 0;
            ibookData.cmbDarNacherSelectdIndex = 0;
        }
    #endregion
}
}
