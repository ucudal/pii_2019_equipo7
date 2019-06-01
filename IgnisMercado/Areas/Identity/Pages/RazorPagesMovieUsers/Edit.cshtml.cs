using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Areas.Identity.Data;

namespace RazorPagesMovie.Areas.Identity.Pages.RazorPagesUsers
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesMovie.Areas.Identity.Data.RazorPagesMovieIdentityDbContext _context;

        public EditModel(RazorPagesMovie.Areas.Identity.Data.RazorPagesMovieIdentityDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(RazorPagesUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RazorPagesUserExists(RazorPagesUser.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RazorPagesUserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
