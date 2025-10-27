using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using funcionalfitness.BD.datos;
using funcionalfitness.repositorio;

namespace funcionalfitness.BD.datos.entidades
{
    public class RegistroUsuario : EntityBase
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;
        public int dni { get; set; }
        public string gmail { get; set; } = string.Empty;
        public int edad { get; set; }
        public string hora { get; set; } = string.Empty;
        public string dias { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public string estado { get; set; } = string.Empty;
        public int codigoingreso { get; set; }
        public int peso { get; set; } 
        public int altura { get; set; } 
    }
}
