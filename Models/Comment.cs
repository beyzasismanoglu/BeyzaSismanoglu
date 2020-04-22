using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore1.Models
{
    public class Comment
    {
        [DisplayName("Yorum Numarası")]
        public int Id { get; set; }

        [DisplayName("Yorum Başlığı")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Title { get; set; }
        
        [DisplayName("Yorum Detayı")]
        public string Detail { get; set; }

        [DisplayName("Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }

        public int BookId { get; set; }

        [DisplayName("Hangi Kitap İçin?")]
        public Book Book { get; set; }
    }
}
