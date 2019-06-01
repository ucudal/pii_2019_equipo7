using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Areas.Identity.Data;

namespace RazorPagesMovie.Areas.Identity.Pages.RazorPagesUsers
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie.Areas.Identity.Data.RazorPagesMovieIdentityDbContext _context;

        public DetailsModel(RazorPagesMovie.Areas.Identity.Data.RazorPagesMovieIdentityDbContext context)
        {
            _context = context;
        }

        public RazorPagesUser RazorPagesUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RazorPagesUser = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);

            if (RazorPagesUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
