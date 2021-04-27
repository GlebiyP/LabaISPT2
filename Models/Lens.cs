using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Lens : Product
    {
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Рік випуску")]
        public string LensYear { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Фокусна відстань")]
        public string FocalLength { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Діафрагма")]
        [Range(0, 25, ErrorMessage = "Невірне значення!")]
        public string Diaphragm { get; set; }
    }
}
