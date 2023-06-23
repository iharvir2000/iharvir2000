using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bikes.Models;

namespace bikes.Pages_bike
{
    public class CreateModel : PageModel
    {
        private readonly bikesContext _context;

        public CreateModel(bikesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public bike bike { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.bike.Add(bike);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
