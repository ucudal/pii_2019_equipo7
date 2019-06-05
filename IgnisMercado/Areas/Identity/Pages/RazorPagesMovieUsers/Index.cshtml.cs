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
    public class IndexModel : PageModel
    {
        private readonly IgnisMercado.Areas.Identity.Data.IgnisMercadoIdentityDbContext _context;

        public IndexModel(IgnisMercado.Areas.Identity.Data.IgnisMercadoIdentityDbContext context)
        {
            _context = context;
        }

        public IList<RazorPagesUser> RazorPagesUser { get;set; }

        public async Task OnGetAsync()
        {
            RazorPagesUser = await _context.Users.ToListAsync();
        }
    }
}
