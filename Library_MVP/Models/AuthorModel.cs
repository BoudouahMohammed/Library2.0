using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVP.Models
{
    public class AuthorModel
    {
        public int idAuthor { get; set; }
        public string nameAuthor { get; set; }
        public string dateAuthor { get; set; }
        public int idCountry{ get; set; }
    }
}
