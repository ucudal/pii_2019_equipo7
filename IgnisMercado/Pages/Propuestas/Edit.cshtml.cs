using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;
using IgnisMercado.Data;

namespace IgnisMercado.Pages.Propuestas
{
    public class EditModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        public List<SelectListItem> NivelesDif { get; }
        public int NiveleDif { get; }

        public EditModel(IgnisMercado.Models.ApplicationContext context)
        {
           _context = context;
            
            this.NivelesDif = new List<SelectListItem>();

            for (int i = 0; i < IgnisData.NivelesDeDificultad.Length; i++)
              {
                this.NivelesDif.Add(new SelectListItem { Value = i.ToString(), Text = IgnisData.NivelesDeDificultad[i] });
            }
                
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Propuesta.NivelDeDificultad= IgnisData.NivelesDeDificultad[NiveleDif];
            Propuesta.CalcularCostoEstimado();


            _context.Attach(Propuesta).State = EntityState.Modified;

            
            
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PropuestaExists(Propuesta.ID))
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

        private bool PropuestaExists(int id)
        {
            return _context.Propuesta.Any(e => e.ID == id);
        }
    }
}
