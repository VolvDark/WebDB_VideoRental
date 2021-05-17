using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_VideoRental.Models
{
    public class employee
    {
        [Display(Name = "Код сотрудника")]
        public long id { get; set; }
        [Display(Name = "ФИО")]
        public string name { get; set; }
        [Display(Name = "Возраст")]
        public int age { get; set; }
        [Display(Name = "Пол")]
        public string gender { get; set; }
        [Display(Name = "Адрес")]
        public string address { get; set; }
        [Display(Name = "Телефон")]
        public string phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassData { get; set; }
        [Display(Name = "Код должности")]
        public long PositionID { get; set; }
        [Display(Name = "Должность")]
        public position Position { get; set; }
    }
}
