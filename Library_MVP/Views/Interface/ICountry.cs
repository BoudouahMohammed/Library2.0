using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    public interface ICountry
    {
        int Id { get; set; }
        string Country_Name { get; set; }
        object txbNameCountry { get; set; }
        object btnAdd { get; set; }
        object btnUpdate { get; set; }
        object btnRemove { get; set; }
        object btnRemoveAll { get; set; }
    }
}
