using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Areas
{
    public class IndexModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public IndexModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

        public IList<Area> Area { get;set; }

        public async Task OnGetAsync()
        {
            Area = await _context.Area.ToListAsync();
        }
    }
}
