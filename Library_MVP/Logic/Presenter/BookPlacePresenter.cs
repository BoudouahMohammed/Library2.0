using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Logic.Presenter
{
    
    class BookPlacePresenter
    {
        IBookPlace ibookPlace;
        BookPlaceModel bookPlaceModel = new BookPlaceModel();
        bool check;

        #region Constructor
        public BookPlacePresenter(IBookPlace view)
        {
            this.ibookPlace = view;
        }
        #endregion

        #region Connect between model cat and interface cat
        private void connectBetweenModelInterface()
        {
            bookPlaceModel.Id = ibookPlace.Id;
            bookPlaceModel.BookPlaceName = ibookPlace.BookPlaceName;
        }
        #endregion

        #region Functions ==> Insert,Update,Delete and DeleteAll
        public bool BookPlaceInsert()
        {
            connectBetweenModelInterface();
            if (bookPlaceModel.BookPlaceName.Trim() == string.Empty)
            {
                check = false;
            }
            else
            {
                check = BookPlaceServices.bookPlaceInsert(bookPlaceModel.Id, bookPlaceModel.BookPlaceName);
                AutoNumber();
            }
            return check;
        }
        public bool BookPlaceUpdate()
        {
            connectBetweenModelInterface();
            if (bookPlaceModel.BookPlaceName.Trim() == string.Empty)
            {
                check = false;
            }
            else
            {
                check = BookPlaceServices.bookPlaceUpdate(bookPlaceModel.Id, bookPlaceModel.BookPlaceName);
                AutoNumber();
            }
            return check;
        }
        public bool BookPlaceDelete()
        {
            connectBetweenModelInterface();
            return BookPlaceServices.bookPlaceDelete(bookPlaceModel.Id);
        }
        public bool BookPlaceDeleteAll()
        {
            connectBetweenModelInterface();
            return BookPlaceServices.bookPlaceDeleteAll();
        }
        #endregion

        #region Functions ==>AutoNumber, getCountAllRow, UpdateRomoveButtons and getCountAllRow
        public void AutoNumber()
        {
            string id = Convert.ToString(BookPlaceServices.bookPlacegetMaxID().Rows[0][0]);
            if (id == null || id == string.Empty)
            {
                ibookPlace.Id = 1;
            }
            else
            {
                ibookPlace.Id = Convert.ToInt32(BookPlaceServices.bookPlacegetMaxID().Rows[0][0]) + 1;
            }
            ibookPlace.BookPlaceName = string.Empty;
            ibookPlace.txbNameBookPlace = true;
            ibookPlace.btnAdd = true;
            ibookPlace.btnModifier = false;
            ibookPlace.btnRemove = false;
            ibookPlace.btnRemoveAll = false;
        }
        public int getCountAllRowBookPlace()
        {
            return BookPlaceServices.bookPlaceGetAllData().Rows.Count;
        }
        public void UpdateRomoveButtons()
        {
            ibookPlace.txbNameBookPlace = true;
            ibookPlace.btnAdd = false;
            ibookPlace.btnModifier = true;
            ibookPlace.btnRemove = true;
            ibookPlace.btnRemoveAll = true;
        }
        public int getCountAllRow()
        {
            return BookPlaceServices.bookPlaceGetAllData().Rows.Count;
        }
        #endregion
    }
}
