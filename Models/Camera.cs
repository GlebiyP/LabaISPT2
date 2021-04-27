using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Camera : Product
    {
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Range(0, 1000, ErrorMessage = "Значення повинно бути від 0 до 1000!")]
        [Display(Name = "Мегапікселі")]
        public string Megapixels { get; set; }

        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Range(1900, 2021, ErrorMessage = "Невірне значення!")]
        [Display(Name = "Рік випуску")]
        public string CameraYear { get; set; }
    }
}
