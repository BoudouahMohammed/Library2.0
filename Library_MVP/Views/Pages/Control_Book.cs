using DevExpress.XtraEditors;
using Library_MVP.Logic.Presenter;
using Library_MVP.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_MVP.Views.Pages
{
    public partial class Control_Book : DevExpress.XtraEditors.XtraUserControl , IBookData
    {
        BookDataPresenter bookDataPresenter;
        //bool check;
        public Control_Book()
        {
            InitializeComponent();
            bookDataPresenter = new BookDataPresenter(this);
        }
        #region Implement Interface
        public int Row { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ID { get => Convert.ToInt32(textEditId.Text.Trim()); set => textEditId.Text = value.ToString(); }
        public string BookName { get => textEditName.Text.Trim(); set => textEditName.Text = value; }
        public int CatID { get => comboBoxCategory.SelectedIndex; set => comboBoxCategory.SelectedIndex = value; }
        public int AuthorID { get => comboBoxAuther.SelectedIndex; set => comboBoxAuther.SelectedIndex = value; }
        public int CountryID { get => comboBoxCountry.SelectedIndex; set => comboBoxCountry.SelectedIndex = value; }
        public int DarID { get => comboBoxDarNacher.SelectedIndex; set => comboBoxDarNacher.SelectedIndex = value; }
        public string SubCat { get => textEditSubCategory.Text.Trim(); set => textEditSubCategory.Text = value; }
        public string Date { get => dateEditDate.Text; set => dateEditDate.Text = value; }
        public int PageNumbers { get => Convert.ToInt32(numericUpDownNumberPage.Value); set => numericUpDownNumberPage.Value = value; }
        public int PlaceID { get => comboBoxPlaceBook.SelectedIndex; set => comboBoxPlaceBook.SelectedIndex = value; }
        public string BookStatu { get => textEditStatus.Text.Trim(); set => textEditStatus.Text = value; }
        public decimal BookPrice { get => Convert.ToDecimal(numericUpDownPrix.Value); set => numericUpDownPrix.Value = value; }
        public string Notes { get => memoEditNote.Text.Trim(); set => memoEditNote.Text = value; }
        public object cmbAuthor { get => comboBoxAuther.DataSource; set => comboBoxAuther.DataSource = value; }
        public object cmbCountry { get => comboBoxCountry.DataSource; set => comboBoxCountry.DataSource = value; }
        public object cmbCat { get => comboBoxCategory.DataSource; set => comboBoxCategory.DataSource = value; }
        public object cmbPlace { get => comboBoxPlaceBook.DataSource; set => comboBoxPlaceBook.DataSource = value; }
        public object cmbDarNacher { get => comboBoxDarNacher.DataSource; set => comboBoxDarNacher.DataSource = value; }
        public object cmbBooks { get => comboBoxChooseBook.DataSource; set => comboBoxChooseBook.DataSource = value; }
        public string cmbAuthorDisplayMember { get => comboBoxAuther.DisplayMember; set => comboBoxAuther.DisplayMember = value; }
        public string cmbAuthorValueMember { get => comboBoxAuther.ValueMember; set => comboBoxAuther.ValueMember = value; }
        public string cmbCountryDisplayMember { get => comboBoxCountry.DisplayMember; set => comboBoxCountry.DisplayMember = value; }
        public string cmbCountryValueMember { get => comboBoxCountry.ValueMember; set => comboBoxCountry.ValueMember = value; }
        public string cmbCatDisplayMember { get => comboBoxCategory.DisplayMember; set => comboBoxCategory.DisplayMember = value; }
        public string cmbCatValueMember { get => comboBoxCategory.ValueMember; set => comboBoxCategory.ValueMember = value; }
        public string cmbPlaceDisplayMember { get => comboBoxPlaceBook.DisplayMember; set => comboBoxPlaceBook.DisplayMember = value; }
        public string cmbPlaceValueMember { get => comboBoxPlaceBook.ValueMember; set => comboBoxPlaceBook.ValueMember = value; }
        public string cmbDarNacherDisplayMember { get => comboBoxDarNacher.DisplayMember; set => comboBoxDarNacher.DisplayMember = value; }
        public string cmbNacherValueMember { get => comboBoxDarNacher.ValueMember; set => comboBoxDarNacher.ValueMember = value; }
        public string cmbBooksDisplayMember { get => comboBoxChooseBook.DisplayMember; set => comboBoxChooseBook.DisplayMember = value; }
        public string cmbBooksValueMember { get => comboBoxChooseBook.ValueMember; set => comboBoxChooseBook.ValueMember = value; }
        public int cmbAuthorSelectdIndex { get => comboBoxAuther.SelectedIndex; set => comboBoxAuther.SelectedIndex = value; }
        public int cmbAuthorSelectdValue { get => Convert.ToInt32(comboBoxAuther.SelectedValue); set => comboBoxAuther.SelectedValue = value; }
        public int cmbCountrySelectdIndex { get => comboBoxCountry.SelectedIndex; set => comboBoxCountry.SelectedIndex = value; }
        public int cmbCountrySelectdValue { get => Convert.ToInt32(comboBoxCountry.SelectedValue); set => comboBoxCountry.SelectedValue = value; }
        public int cmbCatSelectdIndex { get => comboBoxCategory.SelectedIndex; set => comboBoxCategory.SelectedIndex = value; }
        public int cmbCatSelectdValue { get => Convert.ToInt32(comboBoxCategory.SelectedValue); set => comboBoxCategory.SelectedValue = value; }
        public int cmbPlaceSelectdIndex { get => comboBoxPlaceBook.SelectedIndex; set => comboBoxPlaceBook.SelectedIndex = value; }
        public int cmbPlaceSelectdValue { get => Convert.ToInt32(comboBoxPlaceBook.SelectedValue); set => comboBoxPlaceBook.SelectedValue = value; }
        public int cmbDarNacherSelectdIndex { get => comboBoxDarNacher.SelectedIndex; set => comboBoxDarNacher.SelectedIndex = value; }
        public int cmbNacherSelectdValue { get => Convert.ToInt32(comboBoxDarNacher.SelectedValue); set => comboBoxDarNacher.SelectedValue = value; }
        public int cmbBooksSelectdIndex { get => comboBoxChooseBook.SelectedIndex; set => comboBoxChooseBook.SelectedIndex = value; }
        public int cmbBooksSelectdValue { get => Convert.ToInt32(comboBoxChooseBook.SelectedValue); set => comboBoxChooseBook.SelectedValue = value; }
        bool IBookData.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = value; }
        public bool btnUpdate { get => btnModifier.Enabled; set => btnModifier.Enabled = value; }
        public bool btnRemove { get => btnSuprimer.Enabled; set => btnSuprimer.Enabled = value; }
        public bool btnRemoveAll { get => btnSuprimerAll.Enabled; set => btnSuprimerAll.Enabled = value; }
        public string txbNameBook { get => textEditName.Text; set => textEditName.Text = value; }
        public string txbSubCat { get => textEditSubCategory.Text; set => textEditSubCategory.Text = value; }
        public string txbStatus { get => textEditStatus.Text; set => textEditStatus.Text = value; }
        public string txbNote { get => memoEditNote.Text; set => memoEditNote.Text = value; }
        public int numiriquePrice { get => Convert.ToInt32(numericUpDownPrix.Value); set => numericUpDownPrix.Value = value; }
        public int numiriquePage { get => Convert.ToInt32(numericUpDownNumberPage.Value); set => numericUpDownNumberPage.Value = value; }
        public object dateTime { get => dateEditDate.EditValue; set => dateEditDate.EditValue = value; }
        public object txbNameFocus { get => textEditName.Focus(); set => textEditName.Focus(); }
        #endregion

        #region Events
        private void Control_Book_Load(object sender, EventArgs e)
        {
            bookDataPresenter.FillCMBCountry();
            bookDataPresenter.FillCMBDarNacher();
            bookDataPresenter.FillCMBCategory();
            bookDataPresenter.FillCMBPlaces();
            bookDataPresenter.FillCMBAuthor();
            bookDataPresenter.AutoNumber();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void btnModifier_Click(object sender, EventArgs e)
        {

        }
        private void btnSuprimer_Click(object sender, EventArgs e)
        {

        }
        private void btnSuprimerAll_Click(object sender, EventArgs e)
        {

        }
        private void btnRefriche_Click(object sender, EventArgs e)
        {
            bookDataPresenter.AutoNumber();
        }
        #endregion
    }
}
