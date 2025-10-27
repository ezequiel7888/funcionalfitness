using Microsoft.Identity.Client;
using System;
using funcionalfitness.BD.datos;
using funcionalfitness.BD.datos.entidades;
using Microsoft.EntityFrameworkCore;
using funcionalfitness.shared.DTOS;


namespace funcionalfitness.repositorio
{
    public class Repositorio<E> : IRepositorio<E> where E : class, IEntityBase
    {
        private readonly GymDbContext context;

        public Repositorio(GymDbContext context)
        {
            this.context = context;
        }

        public async Task Post(E entity)
        {
            //await context.SaveChangesAsync();
            await context.Set<E>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Post(RegistroUsuarioDTO registroUsuario)
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
            await context.RegistroUsuarios.AddAsync(usuario);
            await context.SaveChangesAsync();
        }
    }
}
