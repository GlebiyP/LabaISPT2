using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Accessory : Product
    {
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Тип аксесуара")]
        public string Type { get; set; }
    }
}
