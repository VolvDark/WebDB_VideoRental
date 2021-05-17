using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_VideoRental.Models
{
    public class genre
    {
        [Display(Name = "Код жанра")]
        public long id { get; set; }
        [Display(Name = "Наименование жанра")]
        public string name { get; set; }
        [Display(Name = "Описание")]
        public string description { get; set; }
    }
}
