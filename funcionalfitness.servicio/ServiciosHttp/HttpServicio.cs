using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace funcionalfitness.servicio.ServiciosHttp
{
    public class HttpServicio : IHttpServicio
    {
        private readonly HttpClient http;

        public HttpServicio(HttpClient Http)
        {
            this.http = Http;
        }

        public async Task<HttpRespuesta<T>> Get<T>(string url)
        {
            var Response = await http.GetAsync(url);
            if (Response.IsSuccessStatusCode)
            {
                var respuesta = await DesSerializar<T>(Response);
                return new HttpRespuesta<T>(respuesta, false, Response);
            }
            else
            {
                return new HttpRespuesta<T>(default, true, Response);
            }


        }

        public async Task<HttpRespuesta<Tresp>> Post<T, Tresp>(string url, T entidad)
        {
            var JsonAEnviar = JsonSerializer.Serialize(entidad);
            var contenido = new StringContent(JsonAEnviar, 
                                              System.Text.Encoding.UTF8, 
                                              "application/json");
            var response = await http.PostAsync(url, contenido);
            if (response.IsSuccessStatusCode)
            {
                var respuesta = await DesSerializar<Tresp>(response);
                return new HttpRespuesta<Tresp>(respuesta, false, response);
            }
            else
            {
                return new HttpRespuesta<Tresp>(default, true, response);
            }
        }

        public async Task<HttpRespuesta<object>> Delete(string url)
        {
            { 
             var response = await http.DeleteAsync(url);
            
            
                return new HttpRespuesta<object>(null, 
                                                 !response.IsSuccessStatusCode, 
                                                  response);
            }
        }

        private async Task<T?> DesSerializar<T>(HttpResponseMessage response)
        {
            var respuestaStri = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(respuestaStri,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
    }

}
