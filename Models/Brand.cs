using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int BrandId { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Ім'я")]
        public string BrandName { get; set; }

        public int CountryId { get; set; }
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Країна-виробник")]
        public virtual Country Country { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
