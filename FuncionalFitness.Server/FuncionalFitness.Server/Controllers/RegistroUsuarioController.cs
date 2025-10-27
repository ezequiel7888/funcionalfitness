using funcionalfitness.BD.datos.entidades;
using funcionalfitness.repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using funcionalfitness.shared.DTOS;


namespace FuncionalFitness.Server.Controllers
{
    [ApiController]
    [Route("api/registrousuario")]
    public class RegistroUsuarioController : ControllerBase
    {
        private readonly GymDbContext context;
        private readonly IRepositorio<RegistroUsuario> repositorio;

        public RegistroUsuarioController(GymDbContext context,
                                         IRepositorio<RegistroUsuario> repositorio) 
        {
            this.context = context;
            this.repositorio = repositorio;
            
        }

        [HttpPost]//api/registrousuario/registro
        public async Task<ActionResult<int>> Post(RegistroUsuarioDTO registroUsuario)
        {
            try
            {
                RegistroUsuario usuario = new RegistroUsuario
                {
                    nombre = registroUsuario.nombre,
                    apellido = registroUsuario.apellido,
                    dni = registroUsuario.dni,
                    gmail = registroUsuario.gmail,
                    edad = registroUsuario.edad,
                    hora = registroUsuario.hora,
                    dias = registroUsuario.dias,
                    descripcion = registroUsuario.descripcion,
                    estado = registroUsuario.estado,
                    codigoingreso = new Random().Next(1000, 9999),
                    peso = registroUsuario.peso,
                    altura = registroUsuario.altura
                };
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            await repositorio.Post(registroUsuario);
           
            //await context.RegistroUsuarios.AddAsync(registroUsuario);
            //context.Add(registroUsuario);
            //await context.SaveChangesAsync();
            return Ok();
        }
    }
}
