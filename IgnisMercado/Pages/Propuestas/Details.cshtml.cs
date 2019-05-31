using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Propuestas
{
    public class DetailsModel : PageModel
    {
        private readonly IgnisMercado.Models.RazorPagesPropuestaContext _context;

        public DetailsModel(IgnisMercado.Models.RazorPagesPropuestaContext context)
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
