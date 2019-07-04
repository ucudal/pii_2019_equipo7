using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IgnisMercado.Models;
using  IgnisMercado.Data;
namespace IgnisMercado.Pages.Propuestas
{
    public class EditModel : PageModel
    {
        public List<SelectListItem> NivelesDif { get; }
        public int NiveleDif { get; }
        public ICalculador Calculcosto;
        private readonly IgnisMercado.Models.ApplicationContext _context;

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
        
        public IEnumerable<Tecnico> AllTecnicos { get; set; }
        public IEnumerable<Tecnico> Tecnicos { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Propuesta = await _context.Propuesta
                .Where(m => m.ID == id)
                .Include(l => l.Puesto)
                .Include(c => c.AsiganrTecnico)
                    .ThenInclude(a => a.Tecnico)
                .AsNoTracking()
                .FirstOrDefaultAsync();
            if (Propuesta == null)
            {
                return NotFound();
            }
            this.Tecnicos = Propuesta.AsiganrTecnico
                .Select(a => a.Tecnico);


            string nameFilter = "";
            if (this.SearchString != null)
            {
                nameFilter = this.SearchString.ToUpper();
            }
            this.AllTecnicos = await _context.Tecnico
                .Where(a =>!Tecnicos.Contains(a))
                .Where(a => !string.IsNullOrEmpty(nameFilter) ? a.Nombre.ToUpper().Contains(nameFilter) : true)
                .ToListAsync();
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var propuestaToUpdate = await _context.Propuesta
                .Include(l => l.Puesto)
                .Include(a => a.AsiganrTecnico)
                    .ThenInclude(a => a.Tecnico)
                .FirstOrDefaultAsync(m => m.ID == id);
          
            
          
          
            if (await TryUpdateModelAsync<Propuesta>(
                propuestaToUpdate,
                "Propuesta",
                i => i.Title, i => i.FechaLimite,
                i => i.CostoEstimado, i => i.EstimadoDeHora,
                i => i.Puesto, i => i.Estado, i => i.DescripcionDeLaPropuesta, i => i.FechaLimite, i => i.NivelDeDificutad

            ))



            {
                if (String.IsNullOrWhiteSpace(propuestaToUpdate.Puesto?.TrabajoName))
                {
                    propuestaToUpdate.Puesto = null;
                }


               
                  Propuesta.NivelDeDificutad = IgnisData.NivelesDeDificultad[NiveleDif];

              
                /*Utilizamos el patron de polimorfismo ya que como las clases CalculadorBasico y CalculadorAvanzado inplmentan la inteface ICalcular realiza una operacion, la clase que se instancie cambara el precio hora.  */
                
                if(IgnisData.NivelesDeDificultad[NiveleDif]==IgnisData.NivelesDeDificultad[0]){
                     this.Calculcosto = new CalculadorBasico(Propuesta);
                    }
                else if (IgnisData.NivelesDeDificultad[NiveleDif]==IgnisData.NivelesDeDificultad[1]){

                     this.Calculcosto = new CalculadorAvanzado(Propuesta);
                     
                }

                 /*Caprurams la excepción que puede causar si  no se recibe el valor correcto desde l form y redirigimos a la index  */
                try {
                    Propuesta.CostoEstimado= this.Calculcosto.Calcular();

                }
                catch{
                        return NotFound();
                }


            _context.Attach(propuestaToUpdate).State = EntityState.Modified;
            
           
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
            }
            return RedirectToPage("./Index");
        }

        public async Task<IActionResult> OnPostDeleteTecnicoAsync(int id, int TecnicoToDeleteID)
        {
            Propuesta propuestaToUpdate = await _context.Propuesta
                .Include(l => l.Puesto)
                .Include(a => a.AsiganrTecnico)
                    .ThenInclude(a => a.Tecnico)
                .FirstOrDefaultAsync(m => m.ID == id);

            await TryUpdateModelAsync<Propuesta>(propuestaToUpdate);

            var TecnicoToDelete = propuestaToUpdate.AsiganrTecnico.Where(a => a.TecnicoID == TecnicoToDeleteID).FirstOrDefault();
            if (TecnicoToDelete != null)
            {
                propuestaToUpdate.AsiganrTecnico.Remove(TecnicoToDelete);
            }

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

            return Redirect(Request.Path + $"?id={id}");
        }

        public async Task<IActionResult> OnPostAddTecnicoAsync(int? id, int? tecnicoToAddID)
        {
            Propuesta propuestaToUpdate = await _context.Propuesta
                .Include(a => a.AsiganrTecnico)
                    .ThenInclude(a => a.Tecnico)
                .FirstOrDefaultAsync(m => m.ID == Propuesta.ID);

            await TryUpdateModelAsync<Propuesta>(propuestaToUpdate);


            if (propuestaToUpdate != null)
            {
                Tecnico tecnicoToAdd = await _context.Tecnico.Where(a => a.ID == tecnicoToAddID).FirstOrDefaultAsync();
                if (tecnicoToAdd != null)
                {
                    var AsiganrTecnicoToAdd = new AsiganrTecnico() {
                        TecnicoID= tecnicoToAddID.Value,
                        Tecnico = tecnicoToAdd,
                        PropuestaID = propuestaToUpdate.ID,
                        Propuesta = propuestaToUpdate };
                    propuestaToUpdate.AsiganrTecnico.Add(AsiganrTecnicoToAdd);
                }
            }

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

            return Redirect(Request.Path + $"?id={id}");

    }

            private bool PropuestaExists(int id)
        {
            return _context.Propuesta.Any(e => e.ID == id);
        }
}
}