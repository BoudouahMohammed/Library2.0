using DevExpress.XtraBars;
using Library_MVP.Logic.Presenter;
using Library_MVP.Views.Controls;
using Library_MVP.Views.Pages;
using System;
using System.Windows.Forms;


namespace Library_MVP.Views.Forms
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MainPresenter mainPresenter;
        public FrmMain()
        {
            InitializeComponent();
            mainPresenter = new MainPresenter(this);
        }
        #region Events Item Click
        private void barButtonCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPresenter.LoadPage(new Control_Category());  
        }
        private void barButtonAuther_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPresenter.LoadPage(new Control_Author());
        }
        private void barButtonBook_Borrow_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPresenter.LoadPage(new Control_BookPlace());
        }
        private void barButtonDar_Nacher_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPresenter.LoadPage(new Control_Dar_Nacher());
        }

        private void barButtonCountry_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPresenter.LoadPage(new Control_Country());
        }
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            mainPresenter.LoadPage(new Control_Book());
        }
        #endregion


    }
}