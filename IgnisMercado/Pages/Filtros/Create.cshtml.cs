using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Filtros
{
    public class CreateModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext  _context;

        public CreateModel(IgnisMercado.Models.IgnisContext  context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Filtro Filtro { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Filtro.Add(Filtro);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}