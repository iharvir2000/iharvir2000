using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bikes.Models;

namespace bikes.Pages_bike
{
    public class DetailsModel : PageModel
    {
        private readonly bikesContext _context;

        public DetailsModel(bikesContext context)
        {
            _context = context;
        }

        public bike bike { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            bike = await _context.bike.FirstOrDefaultAsync(m => m.ID == id);

            if (bike == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
