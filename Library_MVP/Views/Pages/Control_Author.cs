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
    public partial class Control_Author : DevExpress.XtraEditors.XtraUserControl , IAuthor
    {
        AuthorPresenter authorPresenter;
        bool check;
        public Control_Author()
        {
            InitializeComponent();
            authorPresenter = new AuthorPresenter(this);
            LoadDataBase();
        }

        #region Implimeni Interface
        public int idAuthor { get => Convert.ToInt32(txbID.Text.Trim()); set => txbID.Text = value.ToString(); }
        public string nameAuthor { get => txbName.Text.Trim(); set => txbName.Text = value; }
        public string dateAuthor { get => dateTimeAuther.Text; set => dateTimeAuther.Text = value; }
        public int idCountry { get => Convert.ToInt32(cmbCountry.SelectedValue); set => cmbCountry.SelectedValue = value; }
        public object txbAuthor { get => txbName.Focus(); set => txbName.Focus(); }
        public object cmbCauntry { get => cmbCountry.DataSource; set => cmbCountry.DataSource = value; }
        public string AuthorDisplayMember { get => cmbCountry.DisplayMember; set => cmbCountry.DisplayMember = value; }
        public string AuthorValueMember { get => cmbCountry.ValueMember; set => cmbCountry.ValueMember = value; }
        public int SelectedIndex { get => cmbCountry.SelectedIndex; set => cmbCountry.SelectedIndex = value; }
        bool IAuthor.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = value; }
        public bool btnUpdate { get => btnModifier.Enabled; set => btnModifier.Enabled = value; }
        public bool btnRemove { get => btnSuprimer.Enabled; set => btnSuprimer.Enabled = value; }
        public bool btnRemoveAll { get => btnSuprimerAll.Enabled; set => btnSuprimerAll.Enabled = value; }
        #endregion

        #region Events
        private void Control_Auther_Load(object sender, EventArgs e)
        {
            authorPresenter.FillCMB();
            authorPresenter.AutoNumber();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check = authorPresenter.AutherInsert();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("96e27447-c7cc-405b-ae54-2aa4f6885d0c");
                LoadDataBase();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("4a64b4ac-a880-4bbe-9ab9-dab9b4a88874");
            }
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            check = authorPresenter.AutherUpdate();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("96e27447-c7cc-405b-ae54-2aa4f6885d0c");
                LoadDataBase();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("4a64b4ac-a880-4bbe-9ab9-dab9b4a88874");
            }
        }
        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            check = authorPresenter.AutherRemove();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("96e27447-c7cc-405b-ae54-2aa4f6885d0c");
                LoadDataBase();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("4a64b4ac-a880-4bbe-9ab9-dab9b4a88874");
            }
        }
        private void btnSuprimerAll_Click(object sender, EventArgs e)
        {
            check = authorPresenter.AutherRemoveAll();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("96e27447-c7cc-405b-ae54-2aa4f6885d0c");
                LoadDataBase();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("4a64b4ac-a880-4bbe-9ab9-dab9b4a88874");
            }
        }
        private void btnRefriche_Click(object sender, EventArgs e)
        {
            authorPresenter.AutoNumber();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControlAuthor.ShowPrintPreview();
        }
        private void gridControlAuthor_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (authorPresenter.getCountAllRow() != 0)
                {
                    txbID.Text = gridViewAuthor.GetFocusedRowCellValue("رقم المؤلف").ToString();
                    txbName.Text = gridViewAuthor.GetFocusedRowCellValue("اسم المؤلف").ToString();
                    cmbCountry.Text = gridViewAuthor.GetFocusedRowCellValue("اسم الدولة").ToString();
                    try
                    {
                        DateTime date = DateTime.ParseExact(gridViewAuthor.GetFocusedRowCellValue("التاريخ").ToString(), "dd/MM/yyyy", null);
                        dateTimeAuther.Text = date.ToString();
                    }
                    catch (Exception) { }
                    authorPresenter.updateRemoveButtons();
                }
            }
            catch (Exception) { }
        }
        #endregion

        #region Load Data
        private void LoadDataBase()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        #endregion
    }
}
