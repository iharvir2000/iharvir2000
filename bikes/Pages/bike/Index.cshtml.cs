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
    public class IndexModel : PageModel
    {
        private readonly bikesContext _context;

        public IndexModel(bikesContext context)
        {
            _context = context;
        }

        public IList<bike> bike { get;set; }

        public async Task OnGetAsync()
        {
            bike = await _context.bike.ToListAsync();
        }
    }
}
