using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionalfitness.BD.datos.entidades
{
    public class Categoria
    {
        public int id { get; set; }

        public string nombre { get; set; } = string.Empty;

        public string descripcion { get; set; } = string.Empty;

        public int edadminima { get; set; }

        public int edadmaxima { get; set; }

        public List<Cliente> clientes { get; set; } = new List<Cliente>();
    }
}
