using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Competencias
{
    public class DetailsModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public DetailsModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

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
    }
}
