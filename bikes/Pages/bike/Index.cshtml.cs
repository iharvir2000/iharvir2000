using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IList<bike> bike { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Models { get; set; }
        [BindProperty(SupportsGet = true)]
        public string bikeModel { get; set; }

        public async Task OnGetAsync()
{
            // Use LINQ to get list of genres.
            IQueryable<string> modelQuery = from m in _context.bike
                                            orderby m.Model
                                            select m.Model;
            
            var bikess = from m in _context.bike
                        select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
            bikess = bikess.Where(s => s.Model.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(bikeModel))
            {
            bikess = bikess.Where(x => x.Model == bikeModel);
            }

            Models = new SelectList(await modelQuery.Distinct().ToListAsync());
            bike = await bikess.ToListAsync();
}
    }
}
