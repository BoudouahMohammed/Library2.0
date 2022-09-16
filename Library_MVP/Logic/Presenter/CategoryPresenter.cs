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
    class CategoryPresenter
    {
        ICategory icategory;
        CategoryModel catModel = new CategoryModel();
        bool check;

        #region Constructor
        public CategoryPresenter(ICategory view)
        {
            this.icategory = view;
        }
        #endregion

        #region Connect between model cat and interface cat
        private void connectBetweenModelInterface()
        {
            catModel.Id = icategory.ID;
            catModel.CatName = icategory.CatName;
        }
        #endregion

        #region Functions ==> Insert,Update,Delete and DeleteAll
        public bool CatInsert()
        {
            connectBetweenModelInterface();
            if (catModel.CatName.Trim() == string.Empty)
            {
                check = false;
            }
            else
            {
                check = CategotyService.categoryInsert(catModel.Id, catModel.CatName);
                AutoNumber();
            }
            return check;
        }
        public bool CatUpdate()
        {
            connectBetweenModelInterface();
            if (catModel.CatName.Trim() == string.Empty)
            {
                check = false;
            }
            else
            {
                check= CategotyService.categoryUpdate(catModel.Id, catModel.CatName);
                AutoNumber();
            }
            return check;
        }
        public bool CatDelete()
        {
            connectBetweenModelInterface();
            return CategotyService.categoryDelete(catModel.Id);
        }
        public bool CatDeleteAll()
        {
            connectBetweenModelInterface();
            return CategotyService.categoryDeleteAll();
        }
        #endregion

        #region Functions ==>AutoNumber, getCountAllRow and UpdateRomoveButtons
        public void AutoNumber()
        {
            string id = Convert.ToString(CategotyService.categorygetMaxID().Rows[0][0]);
            if(id==null || id== string.Empty)
            {
                icategory.ID = 1;
            }
            else
            {
                icategory.ID = Convert.ToInt32(CategotyService.categorygetMaxID().Rows[0][0]) + 1;
            }
            icategory.CatName = string.Empty;
            icategory.txbNameCat = true;
            icategory.btnAdd = true;
            icategory.btnModifier = false;
            icategory.btnRemove = false;
            icategory.btnRemoveAll = false;
        }
        public int getCountAllRow()
        {
            return CategotyService.categoryGetAllData().Rows.Count;
        }
        public void UpdateRomoveButtons()
        {
            icategory.txbNameCat = true;
            icategory.btnAdd = false;
            icategory.btnModifier = true;
            icategory.btnRemove = true;
            icategory.btnRemoveAll = true;
        }
        #endregion
    }
}
