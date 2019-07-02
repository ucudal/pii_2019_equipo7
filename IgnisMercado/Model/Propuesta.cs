    
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IgnisMercado.Data;

namespace IgnisMercado.Models
{
    public class Propuesta 
    {
        
        [Key]
        public  int ID { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Estimado De Hora")]
        public int EstimadoDeHora { get; set; }
        [Display(Name = "Costo Estimado")]
        public int CostoEstimado { get; private set; }
        [Display(Name = "Estado")]
        public string Estado{ get; private set; }
        [Display(Name = "Descripcion De La Propuesta")]
        public string DescripcionDeLaPropuesta { get; set; }    
        [Display(Name = "Tecnico Asignado")]
        public Tecnico TecnicoAsignado { get; set; }
        [Display(Name = "Empresa")]
        public Empresa Empresa {get;set;}
        
        [Display(Name = "Fecha Límite De La Propuesta")]
        public DateTime FechaLimite{get; private set;}
        

        //Se utiliza el patron expert y se otorga la responsabilidad a la clase propuesta de Calcular Costo Estimado ya que tiene toda la informacion  para hacerlo.
      /*  public void CalcularCostoEstimado(){
            int result=0;
            if(this.NivelDeDificultad == IgnisData.NivelesDeDificultad[0]){
            result= this.EstimadoDeHora*IgnisData.PrecioHoraBasico;
            }
            else if (this.NivelDeDificultad == IgnisData.NivelesDeDificultad[1]){
             result= this.EstimadoDeHora*IgnisData.PrecioHoraAvanzado;
            }
            this.CostoEstimado=result;
        }*/
       
    }
}