using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace funcionalfitness.servicio.ServiciosHttp
{
    public class HttpRespuesta<T>
    {
        public T? Respuesta { get; }
        public bool Error { get; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public HttpRespuesta(T? respuesta,
                                bool error, HttpResponseMessage httpResponseMessage)
        {
            Respuesta = respuesta;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }
        public string OptenerError()
        {
            if (!Error)
            {
                return string.Empty;
            }
            else
            {
                var statuscode = HttpResponseMessage.StatusCode;
                switch (statuscode)
                {
                    case HttpStatusCode.NotFound:
                        return "Recurso no encontrado";
                    case HttpStatusCode.Unauthorized:
                        return "No esta logueado";
                    case HttpStatusCode.Forbidden:
                        return "No tiene autorizacion para ejecutar este proceso";
                    case HttpStatusCode.BadRequest:
                        return "No se pudo procesar la informacion";
                    default:
                        return $"Error desconocido: {statuscode}";
                }
            }
            
        }
    }
}

    
            
            


         
    

