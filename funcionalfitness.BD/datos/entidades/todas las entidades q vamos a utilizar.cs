using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcionalfitness.BD.datos.entidades
{
    public class todas_las_entidades_q_vamos_a_utilizar
    {
        public class Cliente
        {
            public int ClienteId { get; set; }
            public string Nombre { get; set; }
            public string DNI { get; set; }
            public DateTime FechaInicioPlan { get; set; }
            public DateTime FechaFinPlan { get; set; }
            public string CodigoIngreso { get; set; }

            public int CategoriaId { get; set; }
            public Categoria Categoria { get; set; }

            public int TipoEntrenamientoId { get; set; }
            public TipoEntrenamiento TipoEntrenamiento { get; set; }

            public ICollection<Notificacion> Notificaciones { get; set; }
        }

        public class Categoria
        {
            public int CategoriaId { get; set; }
            public string Nombre { get; set; } // A, B, C
            public string Descripcion { get; set; } // Adolescentes, Adultos y mayores, Niños
            public int EdadMinima { get; set; }
            public int EdadMaxima { get; set; }

            public ICollection<Cliente> Clientes { get; set; }
        }

        public class TipoEntrenamiento
        {
            public int TipoEntrenamientoId { get; set; }
            public string Nombre { get; set; } // Adaptado, terapéutico, etc.
            public string Objetivo { get; set; }

            public ICollection<Cliente> Clientes { get; set; }
        }

        public class ZonaCorporal
        {
            public int ZonaCorporalId { get; set; }
            public string Nombre { get; set; } // Pecho, espalda, etc.
        }

        public class Clase
        {
            public int ClaseId { get; set; }
            public string Nombre { get; set; }
            public DateTime Hora { get; set; }
            public string Dia { get; set; }

            public ICollection<ClienteClase> ClientesClase { get; set; }
        }

        public class ClienteClase
        {
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }

            public int ClaseId { get; set; }
            public Clase Clase { get; set; }
        }

        public class Notificacion
        {
            public int NotificacionId { get; set; }
            public int ClienteId { get; set; }
            public Cliente Cliente { get; set; }

            public string Mensaje { get; set; }
            public DateTime FechaEnvio { get; set; }
            public bool Leido { get; set; }
        }

    }
}
