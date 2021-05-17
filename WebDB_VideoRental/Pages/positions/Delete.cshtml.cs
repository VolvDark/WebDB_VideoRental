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
    public class DeleteModel : PageModel
    {
        private readonly WebDB_VideoRental.Data.WebDB_VideoRentalContext _context;

        public DeleteModel(WebDB_VideoRental.Data.WebDB_VideoRentalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public position position { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            position = await _context.position.FirstOrDefaultAsync(m => m.id == id);

            if (position == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            position = await _context.position.FindAsync(id);

            if (position != null)
            {
                _context.position.Remove(position);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
