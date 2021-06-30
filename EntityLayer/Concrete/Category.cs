using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }

        [StringLength(200)]
        public string CategortDescription { get; set; }
        public bool CategoryStatus { get; set; } //ekstra kısıtlamaya gerek yok zaten bool dönüyor
        //ilişki kurması sağlandı
        public ICollection<Heading> Headings { get; set; }
    }
}
