using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebDB_VideoRental.Models;

namespace WebDB_VideoRental.Pages.FilReq.Filter
{
    public class FilterPositionModel : PageModel
    {
        private readonly WebDB_VideoRental.Data.WebDB_VideoRentalContext _context;
        public FilterPositionModel(WebDB_VideoRental.Data.WebDB_VideoRentalContext context)
        {
            _context = context;
        }
        public position Position { get; set; }
        public IList<employee> employee { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Position = await _context.position.FirstOrDefaultAsync(m => m.id == id);

            if (Position == null)
            {
                return NotFound();
            }
            employee = await _context.employee.Include(s => s.Position).Where(m => m.PositionID == Position.id).ToListAsync();
            return Page();

        }
    }
}
