using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Competencias
{
    public class EditModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public EditModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Competencia Competencia { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Competencia = await _context.Competencia.FirstOrDefaultAsync(m => m.ID == id);

            if (Competencia == null)
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

            _context.Attach(Competencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetenciaExists(Competencia.ID))
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

        private bool CompetenciaExists(int id)
        {
            return _context.Competencia.Any(e => e.ID == id);
        }
    }
}
