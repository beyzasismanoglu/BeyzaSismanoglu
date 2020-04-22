using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore1.Models
{
    public class Category
    {
        [DisplayName("Kategori Numarası")]
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage ="3'den kısa veya 100'den fazla karakter girilemez.")]
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Name { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
