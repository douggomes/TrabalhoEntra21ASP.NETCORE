using Microsoft.EntityFrameworkCore;
using SistemaGerProjetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaGerProjetos.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Projeto> Projetos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            //Entity Framework - Garantindo que o BD seja criado. - Code First
            Database.EnsureCreated();
        }
    }
}
