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
    public class DeleteModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public DeleteModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Propuesta = await _context.Propuesta.FindAsync(id);

            if (Propuesta != null)
            {
                _context.Propuesta.Remove(Propuesta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
