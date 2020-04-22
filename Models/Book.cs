using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore1.Models
{
    public class Book
    {

        public string Id { get; set; }


        [StringLength(50, MinimumLength = 3, ErrorMessage = "3'den kısa veya 50'den fazla karakter giremezsiniz.")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Kitap İsmi")]
        public string Title { get; set; }

        [DisplayName("Sayfa Sayısı")]
        public int PageCount { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Yazar")]
        public string Authors { get; set; }


        [DisplayName("Açıklama")]
        [StringLength(512, MinimumLength =3, ErrorMessage = "3'den kısa veya 512'den fazla karakter giremezsiniz.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [DisplayName("Fiyat")]
        public Decimal Price { get; set; }


        [DisplayName("Basım Yılı")]
        public int PressYear { get; set; }

        [DisplayName("Stok Sayısı")]
        public int StockCount { get; set; }


        public int CategoryId { get; set; }

        [DisplayName("Hangi Kategori?")]
        public Category Category { get; set; }

        [DisplayName("Oluşturma Tarihi")]

        public DateTime CreatedDate { get; set; }

        public virtual List<Comment> Comments { get; set; }

        /*public Book()
        {
            CreatedDate = DateTime.Now;
        }*/

    }
}
