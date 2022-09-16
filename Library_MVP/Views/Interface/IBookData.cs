using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    interface IBookData
    {
        int Row { get; set; }
        int ID { get; set; }
        string BookName { get; set; }
        int CatID { get; set; }
        int AuthorID { get; set; }
        int CountryID { get; set; }
        int DarID { get; set; }
        string SubCat { get; set; }
        string Date { get; set; }
        int PageNumbers { get; set; }
        int PlaceID { get; set; }
        string BookStatu { get; set; }
        decimal BookPrice { get; set; }
        string Notes { get; set; }
        //this variables to store comboBox DataSource Properties
        object cmbAuthor { get; set; }
        object cmbCountry { get; set; }
        object cmbCat { get; set; }
        object cmbPlace { get; set; }
        object cmbDarNacher { get; set; }
        object cmbBooks { get; set; }
        //this variables to store DisplayMember and Value Member in combobox
        string cmbAuthorDisplayMember { get; set; }
        string cmbAuthorValueMember { get; set; }
        string cmbCountryDisplayMember { get; set; }
        string cmbCountryValueMember { get; set; }
        string cmbCatDisplayMember { get; set; }
        string cmbCatValueMember { get; set; }
        string cmbPlaceDisplayMember { get; set; }
        string cmbPlaceValueMember { get; set; }
        string cmbDarNacherDisplayMember { get; set; }
        string cmbNacherValueMember { get; set; }
        string cmbBooksDisplayMember { get; set; }
        string cmbBooksValueMember { get; set; }
        //this variables to store selected value and selected index in combobox
        int cmbAuthorSelectdIndex { get; set; }
        int cmbAuthorSelectdValue { get; set; }
        int cmbCountrySelectdIndex { get; set; }
        int cmbCountrySelectdValue { get; set; }
        int cmbCatSelectdIndex { get; set; }
        int cmbCatSelectdValue { get; set; }
        int cmbPlaceSelectdIndex { get; set; }
        int cmbPlaceSelectdValue { get; set; }
        int cmbDarNacherSelectdIndex { get; set; }
        int cmbNacherSelectdValue { get; set; }
        int cmbBooksSelectdIndex { get; set; }
        int cmbBooksSelectdValue { get; set; }
        // Buttons
        bool btnAdd { get; set; }
        bool btnUpdate { get; set; }
        bool btnRemove { get; set; }
        bool btnRemoveAll { get; set; }
        // TextBox
        string txbNameBook { get; set; }
        string txbSubCat { get; set; }
        string txbStatus { get; set; }
        string txbNote { get; set; }
        int numiriquePrice { get; set; }
        int numiriquePage { get; set; }
        object dateTime { get; set; }
        object txbNameFocus { get; set; }
    }
}
