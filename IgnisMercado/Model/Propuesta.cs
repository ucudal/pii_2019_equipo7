    
using System;
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
        [Display(Name = "Nivel De Dificultad")]
        public string NivelDeDificultad { get; set; }
       [Display(Name = "Estimado De Hora")]
        public int EstimadoDeHora { get; set; }
        [Display(Name = "Costo Estimado")]
        public int CostoEstimado { get; private set; }
        [Display(Name = "Estado")]
        public string Estado{ get; private set; }
        [Display(Name = "Descripcion De La Propuesta")]
        public string DescripcionDeLaPropuesta { get; set; }    
        [Display(Name = "Lista De Tecnicos Postulados")]    
        public string ListaDeTecnicosPostulados { get; private set; }
        [Display(Name = "Tecnico Asignado")]
        public string TecnicoAsignado { get; 
        private set; }

        public void CalcularCostoEstimado(){
            int result=0;
            if(this.NivelDeDificultad == IgnisData.NivelesDeDificultad[0]){
            result= this.EstimadoDeHora*IgnisData.PrecioHoraBasico;
            }
            else if (this.NivelDeDificultad == IgnisData.NivelesDeDificultad[1]){
             result= this.EstimadoDeHora*IgnisData.PrecioHoraAvanzado;
            }
            this.CostoEstimado=result;
        }
    }
}