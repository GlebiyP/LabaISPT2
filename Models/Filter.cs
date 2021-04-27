using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Filter : Product
    {
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Тип фільтра")]
        public string Type { get; set; }
    }
}
