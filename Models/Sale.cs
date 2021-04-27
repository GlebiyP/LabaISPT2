using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public int ShopId { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Товар")]
        public virtual Product Product { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Магазин")]
        public virtual Shop Shop { get; set; }
    }
}
