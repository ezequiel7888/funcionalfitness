using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
    
    public class TipoEntrenamiento
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string objetivo { get; set; } = string.Empty;
        public List<Cliente> clientes { get; set; } = new List<Cliente>();
        public int zonacorporalid { get; set; }
        public List<ZonaCorporal> zonascorporales { get; set; } = new List<ZonaCorporal>();
    }
}
