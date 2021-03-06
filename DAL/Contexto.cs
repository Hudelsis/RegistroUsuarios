using System;
using RegistroUsuarios.Entidades; 
using Microsoft.EntityFrameworkCore; 

namespace RegistroUsuarios.DAL
{
    
    public class Contexto : DbContext  
    {
        public DbSet<Usuarios> Usuarios { get; set; } 

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Base.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios
            {
                UsuarioId = 1,
                Nombres = "Hudelsis",
                Apellidos = "Antigua",
                FechaCreacion = new DateTime(2020, 11, 20),
                NombreUsuario = "admin",
                Contrasena = "5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5"
            });
        }
    }
}