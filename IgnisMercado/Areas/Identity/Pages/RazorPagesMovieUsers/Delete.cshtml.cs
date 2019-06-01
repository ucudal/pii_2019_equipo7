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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesMovie.Areas.Identity.Data.RazorPagesMovieIdentityDbContext _context;

        public DeleteModel(RazorPagesMovie.Areas.Identity.Data.RazorPagesMovieIdentityDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RazorPagesUser = await _context.Users.FindAsync(id);

            if (RazorPagesUser != null)
            {
                _context.Users.Remove(RazorPagesUser);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
