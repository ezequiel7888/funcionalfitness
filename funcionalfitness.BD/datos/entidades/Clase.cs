using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
    
    public class Clase
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public DateTime hora { get; set; }
        public string dia { get; set; } = string.Empty;
        public List<ClienteClase> clientesclase { get; set; } = new List<ClienteClase>();
    }
}
