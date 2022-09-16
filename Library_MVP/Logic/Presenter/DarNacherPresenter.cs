using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;

namespace Library_MVP.Logic.Presenter
{
    class DarNacherPresenter
    {
        IDarNacher idarNacher;
        DarNacherModel darNacherModel = new DarNacherModel();
        bool check;

        #region Constrictor
        public DarNacherPresenter(IDarNacher view)
        {
            this.idarNacher = view;
        }
        #endregion

        #region Connect between model auther and interface auther
        private void connectBetweenModelInterface()
        {
            darNacherModel.idDar = idarNacher.idDar;
            darNacherModel.nameDar = idarNacher.nameDar;
            darNacherModel.idCountry = idarNacher.idCountry;
        }
        #endregion

        #region Functions ==> AutherInsert, AutherUpdate, AutherRemove and AutherRemoveAll
        public bool DarNacherInsert()
        {
            connectBetweenModelInterface();
            if (darNacherModel.nameDar == string.Empty)
            {
                check = false;
            }
            else
            {
                check = DarNacherService.darNacherInsert(darNacherModel.idDar, darNacherModel.nameDar, darNacherModel.idCountry);
                AutoNumber();
            }
            return check;
        }
        public bool DarNacherUpdate()
        {
            connectBetweenModelInterface();
            if (darNacherModel.nameDar == string.Empty)
            {
                check = false;
            }
            else
            {
                check = DarNacherService.darNacherUpdate(darNacherModel.idDar, darNacherModel.nameDar, darNacherModel.idCountry);
                AutoNumber();
            }
            return check;
        }
        public bool DarNacherRemove()
        {
            connectBetweenModelInterface();
            if (darNacherModel.nameDar == string.Empty)
            {
                check = false;
            }
            else
            {
                check = DarNacherService.darNacherDelete(darNacherModel.idDar);
                AutoNumber();
            }
            return check;
        }
        public bool DarNacherRemoveAll()
        {
            check = DarNacherService.darNacherDeleteAll();
            AutoNumber();
            return check;
        }
        #endregion

        #region Functions FillCMB, AutoNumber, updateRemoveButtons and getCountAllRow
        public void FillCMB()
        {
            idarNacher.cmbCauntry = DarNacherService.darNachergetAllDataCMB();
            idarNacher.AuthorDisplayMember = "Country_Name";
            idarNacher.AuthorValueMember = "ID";
        }
        public void AutoNumber()
        {
            string id = Convert.ToString(DarNacherService.darNacherGetMaxId().Rows[0][0]);
            if (id == null || id == string.Empty)
            {
                idarNacher.idDar = 1;
            }
            else
            {
                idarNacher.idDar = Convert.ToInt32(DarNacherService.darNacherGetMaxId().Rows[0][0]) + 1;
                idarNacher.SelectedIndex = 0;
            }
            idarNacher.txbDarName = true;
            idarNacher.nameDar = string.Empty;
            
            idarNacher.btnAdd = true;
            idarNacher.btnUpdate = false;
            idarNacher.btnRemove = false;
            idarNacher.btnRemoveAll = false;
        }
        public void updateRemoveButtons()
        {
            idarNacher.txbDarName = true;
            idarNacher.btnAdd = false;
            idarNacher.btnRemove = true;
            idarNacher.btnRemoveAll = true;
            idarNacher.btnUpdate = true;
        }
        public int getCountAllRow()
        {
            return DarNacherService.darNachergetAllData().Rows.Count;
        }
        #endregion
    }
}
