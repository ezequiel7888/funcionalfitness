using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace funcionalfitness.BD.datos.entidades
{
   
    public class Cliente
    {
        public int id { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public DateTime fechainicioplan { get; set; }
        public DateTime fechafinplan { get; set; }
        public string codigoingreso { get; set; } = string.Empty;


        public int categoriaid { get; set; }
        public Categoria categoria { get; set; } = default!;

        public int tipoentrenamientoid { get; set; }
        public TipoEntrenamiento tipoentrenamiento { get; set; } = default!;

        public List<Notificacion> notificaciones { get; set; } = new List<Notificacion>();
        public List<ClienteClase> clientesclase { get; set; } = new List<ClienteClase>();
    }
}
