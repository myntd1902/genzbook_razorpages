using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GenZBookRazorPages.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
