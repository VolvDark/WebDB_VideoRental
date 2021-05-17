using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_VideoRental.Models;

namespace WebDB_VideoRental.Pages.FilReq.Request
{
    public class PerDepModel : PageModel
    {
        private readonly WebDB_VideoRental.Data.WebDB_VideoRentalContext _context;

        public PerDepModel(WebDB_VideoRental.Data.WebDB_VideoRentalContext context)
        {
            _context = context;
        }

        public IList<employee> employee { get; set; }

        public async Task OnGetAsync()
        {
            employee = await _context.employee.Include(s => s.Position).ToListAsync();
        }
    }
}
