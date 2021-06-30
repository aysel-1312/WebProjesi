using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategortDescription { get; set; }
        public bool CategoryStatus { get; set; }
        //ilişki kurması sağlandı
        public ICollection<Heading> Headings { get; set; }
    }
}
