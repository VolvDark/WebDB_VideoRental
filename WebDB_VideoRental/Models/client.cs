using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_VideoRental.Models
{
    public class client
    {
        public long id { get; set; }
        [Display(Name = "ФИО")]
        public string name { get; set; }
        [Display(Name = "Адрес")]
        public string address { get; set; }
        [Display(Name = "Телефон")]
        public string phone { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassData { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата взятия")]
        public DateTime DatePickup { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Дата возврата")]
        public DateTime DateReturn { get; set; }
        [Display(Name = "Отметка об оплате")]
        public bool IsPayment { get; set; }
        [Display(Name = "Отметка о возврате")]
        public bool IsReturn { get; set; }
        [Display(Name = "Код кассеты 1")]
        public long CassetteID1 { get; set; }
        [Display(Name = "Кассета 1")]
        public cassette Cassette1 { get; set; }
        [Display(Name = "Код кассеты 2")]
        public long CassetteID2 { get; set; }
        [Display(Name = "Кассета 2")]
        public cassette Cassette2 { get; set; }
        [Display(Name = "Код кассеты 3")]
        public long CassetteID3 { get; set; }
        [Display(Name = "Кассета 3")]
        public cassette Cassette3 { get; set; }
        [Display(Name = "Код сотрудника")]
        public long EmployeeID { get; set; }
        [Display(Name = "Сотрудник")]
        public employee Employee { get; set; }

    }
}
