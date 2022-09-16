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
    public partial class Control_Dar_Nacher : DevExpress.XtraEditors.XtraUserControl, IDarNacher
    {
        DarNacherPresenter darNacherPresenter;
        bool check;
        public Control_Dar_Nacher()
        {
            InitializeComponent();
            darNacherPresenter = new DarNacherPresenter(this);
            LoadData();
        }
        #region Implement Interface
        public int idDar { get => Convert.ToInt32(txbDarNacherID.Text.Trim()); set => txbDarNacherID.Text = value.ToString(); }
        public string nameDar { get => txbNameDarNacher.Text.Trim(); set => txbNameDarNacher.Text = value; }
        public int idCountry { get => Convert.ToInt32(cmbCountryDarNacher.SelectedValue); set => cmbCountryDarNacher.SelectedValue = value; }
        public object txbDarName { get => txbNameDarNacher.Focus(); set => txbNameDarNacher.Focus(); }
        public object cmbCauntry { get => cmbCountryDarNacher.DataSource; set => cmbCountryDarNacher.DataSource = value; }
        public string AuthorDisplayMember { get => cmbCountryDarNacher.DisplayMember; set => cmbCountryDarNacher.DisplayMember = value; }
        public string AuthorValueMember { get => cmbCountryDarNacher.ValueMember; set => cmbCountryDarNacher.ValueMember = value; }
        public int SelectedIndex { get => cmbCountryDarNacher.SelectedIndex; set => cmbCountryDarNacher.SelectedIndex = value; }
        public bool btnUpdate { get => btnModifier.Enabled; set => btnModifier.Enabled = value; }
        public bool btnRemove { get => btnSuprimer.Enabled; set => btnSuprimer.Enabled = value; }
        public bool btnRemoveAll { get => btnSuprimerAll.Enabled; set => btnSuprimerAll.Enabled = value; }
        bool IDarNacher.btnAdd { get => btnAdd.Enabled; set => btnAdd.Enabled = value; }
        #endregion

        #region Events
        private void Control_Dar_Nacher_Load(object sender, EventArgs e)
        {
            darNacherPresenter.FillCMB();
            darNacherPresenter.AutoNumber();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            check = darNacherPresenter.DarNacherInsert();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("593b50ab-82a4-443f-8d4c-2aa8d3c3ff74");
                LoadData();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("6e46b25d-00b4-409b-964d-86e8dfc3fb9f");
            }
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {
            check = darNacherPresenter.DarNacherUpdate();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("593b50ab-82a4-443f-8d4c-2aa8d3c3ff74");
                LoadData();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("6e46b25d-00b4-409b-964d-86e8dfc3fb9f");
            }
        }
        private void btnSuprimer_Click(object sender, EventArgs e)
        {
            check = darNacherPresenter.DarNacherRemove();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("593b50ab-82a4-443f-8d4c-2aa8d3c3ff74");
                LoadData();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("6e46b25d-00b4-409b-964d-86e8dfc3fb9f");
            }
        }
        private void btnSuprimerAll_Click(object sender, EventArgs e)
        {
            check = darNacherPresenter.DarNacherRemoveAll();
            if (check)
            {
                toastNotificationsManager1.ShowNotification("593b50ab-82a4-443f-8d4c-2aa8d3c3ff74");
                LoadData();
            }
            else
            {
                toastNotificationsManager1.ShowNotification("6e46b25d-00b4-409b-964d-86e8dfc3fb9f");
            }
        }
        private void btnRefriche_Click(object sender, EventArgs e)
        {
            darNacherPresenter.AutoNumber();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControlDarNacher.ShowPrintPreview();
        }
        private void gridControlDarNacher_DoubleClick(object sender, EventArgs e)
        {
            if (darNacherPresenter.getCountAllRow() != 0)
            {
                try
                {
                    txbDarNacherID.Text = gridViewDarNacher.GetFocusedRowCellValue("رقم الدار").ToString();
                    txbNameDarNacher.Text = gridViewDarNacher.GetFocusedRowCellValue("اسم الدار").ToString();
                    cmbCountryDarNacher.Text = gridViewDarNacher.GetFocusedRowCellValue("اسم الدولة").ToString();
                    darNacherPresenter.updateRemoveButtons();
                }
                catch (Exception)
                {
                }
            }    
        }
        #endregion

        #region Function Load Data
        private void LoadData()
        {
            // This line of code is generated by Data Source Configuration Wizard
            // Fill the SqlDataSource asynchronously
            sqlDataSource1.FillAsync();
        }
        #endregion
    }
}
