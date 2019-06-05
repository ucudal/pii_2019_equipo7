using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Areas.Identity.Data;

namespace IgnisMercado.Areas.Identity.Pages.RazorPagesUsers
{
    public class DetailsModel : PageModel
    {
        private readonly IgnisMercado.Areas.Identity.Data.IgnisMercadoIdentityDbContext _context;

        public DetailsModel(IgnisMercado.Areas.Identity.Data.IgnisMercadoIdentityDbContext context)
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
