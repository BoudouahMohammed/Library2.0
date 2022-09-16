using DevExpress.XtraEditors;
using Library_MVP.Views.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Library_MVP.Logic.Presenter
{
    public class MainPresenter
    {
        private FrmMain _frmMain;
        public MainPresenter(FrmMain main)
        {
            _frmMain = main;
        }
        public void LoadPage(XtraUserControl userControl)
        {
            //Dispose Old Page
            var oldPage = _frmMain.pn_Container.Controls.OfType<XtraUserControl>().FirstOrDefault();
            if(oldPage != null)
            {
                _frmMain.pn_Container.Controls.Remove(oldPage);
                oldPage.Dispose();
            }
            //Load New PAge
            userControl.Dock = System.Windows.Forms.DockStyle.Fill;
            _frmMain.pn_Container.Controls.Add(userControl);
        }
    }
}
