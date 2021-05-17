using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_VideoRental.Data;
using WebDB_VideoRental.Models;

namespace WebDB_VideoRental.Pages.employes
{
    public class DetailsModel : PageModel
    {
        private readonly WebDB_VideoRental.Data.WebDB_VideoRentalContext _context;

        public DetailsModel(WebDB_VideoRental.Data.WebDB_VideoRentalContext context)
        {
            _context = context;
        }

        public employee employee { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            employee = await _context.employee
                .Include(e => e.Position).FirstOrDefaultAsync(m => m.id == id);

            if (employee == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
