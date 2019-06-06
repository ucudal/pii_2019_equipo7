using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;

namespace RazorPagesMovie.Pages.Competencias
{
    public class IndexModel : PageModel
    {
        private readonly IgnisMercado.Models.IgnisContext _context;

        public IndexModel(IgnisMercado.Models.IgnisContext context)
        {
            _context = context;
        }

        public IList<Competencia> Competencia { get;set; }

        public async Task OnGetAsync()
        {
            Competencia = await _context.Competencia.ToListAsync();
        }
    }
}
