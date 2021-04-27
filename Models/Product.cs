using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Product
    {
        public Product()
        {
            Sales = new HashSet<Sale>();
        }

        public virtual int Id { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Range(0, 1000000, ErrorMessage = "Невірне значення!")]
        [Display(Name = "Ціна")]
        public string Price { get; set; }

        public int BrandId { get; set; }
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Бренд")]
        public virtual Brand Brand { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
