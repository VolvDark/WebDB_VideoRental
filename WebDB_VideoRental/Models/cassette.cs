using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_VideoRental.Models
{
    public class cassette
    {
        [Display(Name = "Код кассеты")]
        public long id { get; set; }
        [Display(Name = "Наименование фильма")]
        public string name { get; set; }
        [Display(Name = "Год создание")]
        public int description { get; set; }
        [Display(Name = "Производитель")]
        public string producer { get; set; }
        [Display(Name = "Страна")]
        public string country { get; set; }
        [Display(Name = "Главный актёр")]
        public string MainActor { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата записи")]
        public DateTime DateNote { get; set; }
        [Display(Name = "Код жанра")]
        public long GenreId { get; set; }
        [Display(Name = "Жанр")]
        public genre Genre { get; set; }
        [Display(Name = "Цена")]
        public int cost { get; set; }

    }
}
