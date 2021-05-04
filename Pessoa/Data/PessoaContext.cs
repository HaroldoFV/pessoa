using System;
using Microsoft.EntityFrameworkCore;
using Pessoa.Models;

namespace Pessoa.Data
{
    public class PessoaContext  : DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext> options)
            : base(options)
        { }

        public DbSet<Models.Pessoa> Pessoas{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Pessoa>()
                .Property(p => p.Nome)
                .HasMaxLength(80);

        }
    }
}
