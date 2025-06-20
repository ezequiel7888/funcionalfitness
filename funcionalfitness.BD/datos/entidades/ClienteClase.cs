using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
    
    public class ClienteClase
    {
        public int id { get; set; }
        public Cliente cliente { get; set; } = default!;
        public int claseid { get; set; }
        public Clase clase { get; set; } = default!;
    }
}
