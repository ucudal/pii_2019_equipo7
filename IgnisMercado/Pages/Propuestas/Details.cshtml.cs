using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace RazorPagesMovie.Pages.Propuestas
{
    public class DetailsModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public DetailsModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

        public Propuesta Propuesta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Propuesta = await _context.Propuesta.FirstOrDefaultAsync(m => m.ID == id);

            if (Propuesta == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
