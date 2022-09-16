using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;


namespace Library_MVP.Logic.Presenter
{
    class AuthorPresenter
    {
        IAuthor iauther;
        AuthorModel autherModel = new AuthorModel();
        bool check;

        #region Constructor
        public AuthorPresenter(IAuthor view)
        {
            this.iauther = view;
        }
        #endregion

        #region Connect between model auther and interface auther
        private void connectBetweenModelInterface()
        {
            autherModel.idAuthor = iauther.idAuthor;
            autherModel.nameAuthor = iauther.nameAuthor;
            autherModel.dateAuthor = iauther.dateAuthor;
            autherModel.idCountry = iauther.idCountry;
        }
        #endregion

        #region Functions ==> AutherInsert, AutherUpdate, AutherRemove and AutherRemoveAll
        public bool AutherInsert()
        {
            connectBetweenModelInterface();
            if (autherModel.nameAuthor == string.Empty)
            {
                check = false;
            }
            else
            {
                DateTime date1 = Convert.ToDateTime(autherModel.dateAuthor);
                string date2 = date1.ToString("dd/MM/yyyy");
                check = AuthorService.autherInsert(autherModel.idAuthor, autherModel.nameAuthor, date2, autherModel.idCountry);
                AutoNumber();
            }
            return check;
        }
        public bool AutherUpdate()
        {
            connectBetweenModelInterface();
            if (autherModel.nameAuthor == string.Empty)
            {
                check = false;
            }
            else
            {
                DateTime date1 = Convert.ToDateTime(autherModel.dateAuthor);
                string date2 = date1.ToString("dd/MM/yyyy");
                check = AuthorService.autherUpdate(autherModel.idAuthor, autherModel.nameAuthor, date2, autherModel.idCountry);
                AutoNumber();
            }
            return check;
        }
        public bool AutherRemove()
        {
            connectBetweenModelInterface();
            if (autherModel.nameAuthor == string.Empty)
            {
                check = false;
            }
            else
            {
                check = AuthorService.authorDelete(autherModel.idAuthor);
                AutoNumber();
            }
            return check;
        }
        public bool AutherRemoveAll()
        {
            check = AuthorService.autherDeleteAll();
            AutoNumber();
            return check;
        }
        #endregion

        #region Functions FillCMB, AutoNumber, updateRemoveButtons and getCountAllRow
        public void FillCMB()
        {
            iauther.cmbCauntry = AuthorService.getAllDataCMB();
            iauther.AuthorDisplayMember = "Country_Name";
            iauther.AuthorValueMember = "ID";
        }
        public void AutoNumber()
        {
            string id = Convert.ToString(AuthorService.autherGetMaxId().Rows[0][0]);
            if (id == null || id == string.Empty)
            {
                iauther.idAuthor = 1;
            }
            else
            {
                iauther.idAuthor = Convert.ToInt32(AuthorService.autherGetMaxId().Rows[0][0]) + 1;
            }
            iauther.txbAuthor = true;
            iauther.nameAuthor = string.Empty;
            iauther.dateAuthor = DateTime.Now.ToString();
            iauther.SelectedIndex = 0;
            iauther.btnAdd = true;
            iauther.btnUpdate = false;
            iauther.btnRemove = false;
            iauther.btnRemoveAll = false;
        }
        public void updateRemoveButtons()
        {
            iauther.txbAuthor = true;
            iauther.btnAdd = false;
            iauther.btnRemove = true;
            iauther.btnRemoveAll = true;
            iauther.btnUpdate = true;
        }
        public int getCountAllRow()
        {
            return AuthorService.getAllData().Rows.Count;
        }
        #endregion
    }
}
