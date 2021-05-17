using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_VideoRental.Models
{
    public class position
    {
        [Display(Name = "Код должности")]
        public long id { get; set; }
        [Display(Name = "Наименование должности")]
        public string name { get; set; }
        [Display(Name = "Оклад")]
        public int salary { get; set; }
        [Display(Name = "Обязанности")]
        public string duties { get; set; }
        [Display(Name = "Требования")]
        public string requirements { get; set; }
    }
}
