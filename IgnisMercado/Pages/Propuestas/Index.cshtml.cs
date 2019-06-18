using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;
using IgnisMercado.Models.PropuestasViewModel;

namespace IgnisMercado.Pages.Propuestas
{
    public class IndexModel : PageModel
    {
        private readonly IgnisMercado.Models.ApplicationContext _context;

        public IndexModel(IgnisMercado.Models.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Propuesta> Propuesta { get;set; }

        public async Task OnGetAsync()
        {
            Propuesta = await _context.Propuesta.ToListAsync();
        }
        // public PropuestaIndexData Propuesta { get; set; }
        // public int PropuestaID { get; set; }
        // public int FeedbackID { get; set; }
        // [BindProperty(SupportsGet = true)]
        // public string SearchString { get; set; }
        // public async Task OnGetAsync(int? id, int? actorID)
        // {
        //     // Use LINQ to get list of genres.
        //     IQueryable<string> genreQuery = from m in _context.Propuestas

        // }
        //Consultar con Machado el uso del ViewModel.
        
    } 
}
