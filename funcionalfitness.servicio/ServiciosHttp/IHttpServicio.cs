
namespace funcionalfitness.servicio.ServiciosHttp
{
    public interface IHttpServicio
    {
        Task<HttpRespuesta<object>> Delete(string url);
        Task<HttpRespuesta<T>> Get<T>(string url);
        Task<HttpRespuesta<Tresp>> Post<T, Tresp>(string url, T entidad);
    }
}