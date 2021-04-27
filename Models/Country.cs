using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LabaISPT2.Models
{
    public class Country
    {
        public Country()
        {
            Brands = new HashSet<Brand>();
        }
        public int CountryId { get; set; }
        [Required(ErrorMessage = "Поле не може бути пустим!")]
        [Display(Name = "Країна")]
        public string CountryName { get; set; }
        public virtual ICollection<Brand> Brands { get; set; }
    }
}
