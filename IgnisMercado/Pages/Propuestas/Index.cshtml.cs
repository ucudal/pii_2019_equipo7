using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;
using IgnisMercado.Models.IgnisViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IgnisMercado.Pages.Propuestas
{
    public class IndexModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        public IndexModel(IgnisMercado.Models.ApplicationContext context)
        {
            _context = context;
        }

        public IgnisIndexData Propuesta { get; set; }

        public SelectList Empresas { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public int PropuestaID { get; set; }

        [BindProperty(SupportsGet = true)]
        public string PropuestaEmpresa { get; set; }

        public async Task OnGetAsync(int? id, int? empresaID)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Propuestas
                                            orderby m.Empresa.Nombre
                                            select m.Empresa.Nombre;
            Empresas = new SelectList(await genreQuery.Distinct().ToListAsync());

            Propuesta = new IgnisIndexData();
            Propuesta.Propuestas = await _context.Propuestas
                .Where(s => !string.IsNullOrEmpty(SearchString) ? s.Title.Contains(SearchString) : true)
                .Where(x => !string.IsNullOrEmpty(PropuestaEmpresa) ? x.Empresa.Nombre == PropuestaEmpresa : true)
                .Include(l => l.Puesto)
                .Include(c => c.AsiganrTecnico)
                    .ThenInclude(c => c.Tecnico)
                .AsNoTracking()
                .ToListAsync();

            if (id != null)
            {
                PropuestaID = id.Value;
                Propuesta propuesta = Propuesta.Propuestas.Where(m => m.ID == id.Value).Single();
                Propuesta.Tecnicos = propuesta.AsiganrTecnico.Select(a => a.Tecnico);
            }

            if (empresaID != null)
            {
                empresaID = id.Value;
            }
        }

    
    
    }
}
