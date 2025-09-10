using funcionalfitness.BD.datos.entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FuncionalFitness.Server.Controllers
{
    [ApiController]
    [Route("api/registrousuario")]
    public class RegistroUsuarioController : ControllerBase
    {
        private readonly GymDbContext context;
        public RegistroUsuarioController(GymDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult> Post(RegistroUsuario registroUsuario)
        {
            context.Add(registroUsuario);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
