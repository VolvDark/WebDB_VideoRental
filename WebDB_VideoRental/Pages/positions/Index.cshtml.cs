using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_VideoRental.Data;
using WebDB_VideoRental.Models;

namespace WebDB_VideoRental.Pages.positions
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_VideoRental.Data.WebDB_VideoRentalContext _context;

        public IndexModel(WebDB_VideoRental.Data.WebDB_VideoRentalContext context)
        {
            _context = context;
        }

        public IList<position> position { get;set; }

        public async Task OnGetAsync()
        {
            position = await _context.position.ToListAsync();
        }
    }
}
