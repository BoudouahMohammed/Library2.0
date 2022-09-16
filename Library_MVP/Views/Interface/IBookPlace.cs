using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Views.Interface
{
    public interface IBookPlace
    {
        int Id { get; set; }
        string BookPlaceName { get; set; }
        object txbNameBookPlace { get; set; }
        bool btnAdd { get; set; }
        bool btnModifier { get; set; }
        bool btnRemove { get; set; }
        bool btnRemoveAll { get; set; }
    }
}
