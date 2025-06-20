using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
    
    public class Notificacion
    {
        public int id { get; set; }
        public int clienteid { get; set; }
        public Cliente cliente { get; set; } = default!;
        public string mensaje { get; set; } = string.Empty;
        public DateTime fechaenvio { get; set; }
        public bool leido { get; set; }
        
        
    }
}
