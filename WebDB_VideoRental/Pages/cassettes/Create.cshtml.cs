using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebDB_VideoRental.Data;
using WebDB_VideoRental.Models;

namespace WebDB_VideoRental.Pages.cassettes
{
    public class CreateModel : PageModel
    {
        private readonly WebDB_VideoRental.Data.WebDB_VideoRentalContext _context;

        public CreateModel(WebDB_VideoRental.Data.WebDB_VideoRentalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GenreId"] = new SelectList(_context.genre, "id", "id");
            return Page();
        }

        [BindProperty]
        public cassette cassette { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.cassette.Add(cassette);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
