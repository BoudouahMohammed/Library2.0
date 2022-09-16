using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    public interface ICategory
    {
        int ID { get; set; }
        string CatName { get; set; }
        string CountryGetFocuseId { get; set; }
        string CountryGetFocuseName { get; set; }
        object txbNameCat { get; set; }
        object btnAdd { get; set; }
        object btnModifier { get; set; }
        object btnRemove { get; set; }
        object btnRemoveAll { get; set; }
    }
}
