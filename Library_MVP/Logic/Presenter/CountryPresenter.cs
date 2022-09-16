using DevExpress.XtraGrid;
using Library_MVP.Logic.Services;
using Library_MVP.Models;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace Library_MVP.Logic.Presenter
{
    class CountryPresenter
    {
        ICountry icountry;
        CountryModel countryModel = new CountryModel();
        bool check;

        #region Constructor
        public CountryPresenter(ICountry view)
        {
            this.icountry = view;
        }
        #endregion

        #region Connect between model Country and interface Country
        private void connectBetweenModelInterface()
        {
            countryModel.Id = icountry.Id;
            countryModel.Country_Name = icountry.Country_Name;
        }
        #endregion

        #region Functions ==> Insert,Update,Delete and DeleteAll
        public bool CountryInsert()
        {
            connectBetweenModelInterface();
            if(countryModel.Country_Name.Trim()== string.Empty)
            {
                check = false;
            }
            else
            {
                check = CountryService.countryInsert(countryModel.Id, countryModel.Country_Name);
                AutoNumber();
            }
            return check;
        }
        public bool CountryUpdate()
        {
            connectBetweenModelInterface();
            if (countryModel.Country_Name.Trim() == string.Empty)
            {
                check = false;
                icountry.txbNameCountry = true;
            }
            else
            {
                check = CountryService.countryUpdate(countryModel.Id, countryModel.Country_Name);
                AutoNumber();
            }
            return check;
        }
        public bool CountryDelete()
        {
            connectBetweenModelInterface();
            check = CountryService.countryDelete(countryModel.Id);
            AutoNumber();
            return check;
        }
        public bool CountryDeleteAll()
        {
            check = CountryService.countryDeleteAll();
            AutoNumber();
            return check;
        }
        #endregion

        #region Functions ==>AutoNumber, getCountAllRow and updateRemoveButtons
        public void AutoNumber()
        {
            string id = Convert.ToString(CountryService.CountrygetMaxID().Rows[0][0]);
            if (id==null || id== string.Empty)
            {
                icountry.Id = 1;
            }
            else
            {
                icountry.Id = Convert.ToInt32(CountryService.CountrygetMaxID().Rows[0][0]) + 1;
            }
            icountry.Country_Name = string.Empty;
            icountry.txbNameCountry = true;
            icountry.btnAdd = true;
            icountry.btnRemove = false;
            icountry.btnRemoveAll = false;
            icountry.btnUpdate = false;
        }
        public void updateRemoveButtons()
        {
            icountry.txbNameCountry = true;
            icountry.btnAdd = false;
            icountry.btnRemove = true;
            icountry.btnRemoveAll = true;
            icountry.btnUpdate = true;
        }
        public int getCountAllRow()
        {
            return CountryService.getAllData().Rows.Count;
        }
        #endregion
    }
}
