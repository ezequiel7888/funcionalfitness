using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
    public class RegistroUsuario
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;
        public int dni { get; set; }
        public string gmail { get; set; } = string.Empty;
        public string edad { get; set; } = string.Empty;
        public DateTime hora { get; set; } = DateTime.Now;
        public string dias { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public string estado { get; set; } = string.Empty;
        public int codigoingreso { get; set; }
        public string peso { get; set; } = string.Empty;
        public string altura { get; set; } = string.Empty;
    }
}
