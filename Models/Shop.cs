using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Shop
    {
        public Shop()
        {
            Sales = new HashSet<Sale>();
        }

        public int ShopId { get; set; }
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Назва")]
        public string ShopName { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Статус")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Розташування")]
        public string Location { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
