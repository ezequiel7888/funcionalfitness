using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionalfitness.shared.DTOS
{
    public class RegistroUsuarioDTO
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;

        [Required(ErrorMessage= "el dni es requerido" )]
        public int dni { get; set; } // falta poner este en el formulario de registro
                                     // que es el crearregistrousuario.razor
        [Required(ErrorMessage = "el gmail es requerido")]
        public string gmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "la edad es requerida")]
        public int edad { get; set; }

        [Required(ErrorMessage = "la hora es requerida")]
        public string hora { get; set; } = string.Empty;  // falta poner este en el formulario de registro
                                                          // que es el crearregistrousuario.razor

        [Required(ErrorMessage= "el  dia o los dias son requeridos")]      
        public string dias { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "el estado es requerido")]
        public string estado { get; set; } = string.Empty;

        [Required(ErrorMessage = "el codigo de ingreso es requerido")]
        public int codigoingreso { get; set; } // falta poner este en el formulario de registro
                                               // que es el crearregistrousuario.razor
        public int peso { get; set; } 
        public int altura { get; set; }
    }
}
