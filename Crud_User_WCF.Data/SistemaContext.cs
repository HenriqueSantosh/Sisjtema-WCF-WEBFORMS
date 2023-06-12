using Crud_User_WCF.Data.Entity;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_User_WCF.Data
{
    public class SistemaContext : DbContext
    {
        public DbSet<Usuario> Usuarios;
        //public DbSet<Endereco> Enderecos;
        //public DbSet<UsuarioEnderecoView> UsuarioEnderecoViews { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionlocalSql = "Data Source=DESKTOP-EGGHI11\\SQLEXPRESS;Initial Catalog=SISTEMA_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string connectionVisualStudio = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SISTEMA_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder
                .UseSqlServer(connectionlocalSql)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<UsuarioEnderecoView>().ToView("USUARIO_ENDERECO_VW");
              

            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);

            modelBuilder.Entity<Usuario>().HasIndex(c => c.CPF)
                .IsUnique();

            modelBuilder.Entity<Usuario>().Property(c => c.CPF)
                .IsRequired().HasMaxLength(15);

            modelBuilder.Entity<Usuario>().Property(c => c.Nome).IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Usuario>().Property(c => c.UF).IsRequired()
                .HasMaxLength(2);

            modelBuilder.Entity<Usuario>().Property(c => c.OrGaoExpedicao).IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<Usuario>().Property(c => c.DataExpedicao).IsRequired();

            modelBuilder.Entity<Usuario>().Property(c => c.DataNascimento).IsRequired();

            modelBuilder.Entity<Usuario>().Property(c => c.Sexo).IsRequired()
           .HasMaxLength(10);

            modelBuilder.Entity<Usuario>().Property(c => c.EstadoCivil).IsRequired()
            .HasMaxLength(15);

          modelBuilder.Entity<Usuario>()
         .HasOne(e => e.Endereco)
         .WithOne(e => e.Usuario)
         .HasForeignKey<Endereco>(e => e.IdUsuario)
         .IsRequired().Metadata.DeleteBehavior = DeleteBehavior.Cascade;


            //******************************************************************************//
            modelBuilder.Entity<Endereco>().HasKey(u => u.Id);

            modelBuilder.Entity<Endereco>().Property(c => c.Cep).IsRequired()
               .HasMaxLength(9);

            modelBuilder.Entity<Endereco>().Property(c => c.UF).IsRequired()
               .HasMaxLength(2);

            modelBuilder.Entity<Endereco>().Property(c => c.Bairro).IsRequired()
               .HasMaxLength(50);

            modelBuilder.Entity<Endereco>().Property(c => c.Logradouro).IsRequired()
               .HasMaxLength(100);

            modelBuilder.Entity<Endereco>().Property(c => c.Cidade).IsRequired()
               .HasMaxLength(100);

            modelBuilder.Entity<Endereco>().Property(c => c.Complemento).IsRequired()
               .HasMaxLength(10);

            modelBuilder.Entity<Endereco>().Property(c => c.Numero).
                HasMaxLength(6).IsRequired();

            modelBuilder.Entity<Endereco>()
          .HasOne(e => e.Usuario)
          .WithOne(e => e.Endereco)
          .HasForeignKey<Endereco>(e => e.IdUsuario)
          .IsRequired().Metadata.DeleteBehavior = DeleteBehavior.Cascade;

            base.OnModelCreating(modelBuilder);
        }
    }
}
