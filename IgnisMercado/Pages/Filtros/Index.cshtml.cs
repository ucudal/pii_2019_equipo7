using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace IgnisMercado.Pages.Filtros
{
    public class IndexModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public IndexModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

        public IList<Filtro> Filtro { get;set; }

        public async Task OnGetAsync()
        {
            Filtro = await _context.Filtro.ToListAsync();
        }
    }
}