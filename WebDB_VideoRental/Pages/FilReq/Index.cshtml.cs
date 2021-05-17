using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebDB_VideoRental.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_VideoRental.Data.WebDB_VideoRentalContext _context;
        public IndexModel(WebDB_VideoRental.Data.WebDB_VideoRentalContext context)
        {

            _context = context;
        }
        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelClient { get; set; }
        public List<SelectListItem> SelGenre { get; set; }
        public List<SelectListItem> SelActor { get; set; }
        public List<SelectListItem> SelPayment { get; set; }
        public List<SelectListItem> SelHanded { get; set; }
        public IActionResult OnGet()
        {
            SelPosition = _context.position.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.id.ToString(),
                                      Text = p.name
                                  }).ToList();
            SelClient = _context.client.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.id.ToString(),
                                      Text = p.name
                                  }).ToList();
            SelActor = _context.cassette.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.MainActor,
                                      Text = p.MainActor
                                  }).ToList();
            SelGenre = _context.genre.Select(p =>
                                  new SelectListItem
                                  {
                                      Value = p.id.ToString(),
                                      Text = p.name
                                  }).ToList();
            SelPayment = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "True", Text = "Оплачен"},
                           new SelectListItem{ Value = "False", Text = "Не оплачен"}
                        };
            SelHanded = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "True", Text = "Сдан"},
                           new SelectListItem{ Value = "False", Text = "Не сдан"}
                        };

            return Page();
        }
    }
}
