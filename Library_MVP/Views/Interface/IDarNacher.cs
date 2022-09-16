using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    public interface IDarNacher
    {
        int idDar { get; set; }
        string nameDar { get; set; }
        int idCountry { get; set; }
        object txbDarName { get; set; }
        object cmbCauntry { get; set; }
        string AuthorDisplayMember { get; set; }
        string AuthorValueMember { get; set; }
        int SelectedIndex { get; set; }
        bool btnAdd { get; set; }
        bool btnUpdate { get; set; }
        bool btnRemove { get; set; }
        bool btnRemoveAll { get; set; }
    }
}
