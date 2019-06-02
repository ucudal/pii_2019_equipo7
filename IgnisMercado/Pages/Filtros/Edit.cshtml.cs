using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Filtros
{
    public class EditModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public EditModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Filtro Filtro { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Filtro = await _context.Filtro.FirstOrDefaultAsync(m => m.ID == id);

            if (Filtro == null)
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

            _context.Attach(Filtro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FiltroExists(Filtro.ID))
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

        private bool FiltroExists(int id)
        {
            return _context.Filtro.Any(e => e.ID == id);
        }
    }
}
