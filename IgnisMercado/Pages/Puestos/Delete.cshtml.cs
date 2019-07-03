using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Puestos
{
    public class DeleteModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        public DeleteModel(IgnisMercado.Models.ApplicationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Puesto Puesto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Puesto = await _context.Puesto.FirstOrDefaultAsync(m => m.PropuestaID == id);

            if (Puesto == null)
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

            Puesto = await _context.Puesto.FindAsync(id);

            if (Puesto != null)
            {
                _context.Puesto.Remove(Puesto);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
