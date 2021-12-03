using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PROJETO01.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace PROJETO01.Dados.EntityFramework
{
    public class Contexto : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"Data source = 201.62.57.93; 
                                     Database = dbLAB2_2020; 
                                     User ID = visualstudio; 
                                     Password = visualstudio";
            optionsBuilder.UseSqlServer(conn);
        }

        //Nome das Classes que representarão o Banco de Dados
        public DbSet<Estado> Estado { get; set; }

        //Definição das características das classes com as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estado>()
                .ToTable("Estado")
                .HasKey("UF");

            modelBuilder.Entity<Estado>()
                .Property("UF")
                .HasColumnName("Uf")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Estado>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();
    //////////////////////////////////////////////////////////////////////////////////////
    
            modelBuilder.Entity<Cliente>()
               .ToTable("Cliente")
               .HasKey("ClienteID");

            modelBuilder.Entity<Cliente>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
               .Property("Telefone")
               .HasColumnName("telefone")
               .HasColumnType("varchar(20)")
               .IsRequired();

            modelBuilder.Entity<Cliente>()
               .Property("Email")
               .HasColumnName("Email")
               .HasColumnType("varchar(200)")
               .IsRequired();

            modelBuilder.Entity<Cliente>()
             .Property("Cpf")
             .HasColumnName("Cpf")
             .HasColumnType("char(11)")
             .IsRequired();
            /////////////////////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity<Cidade>()
                .ToTable("Estado")
                .HasKey("UF");

            modelBuilder.Entity<Cidade>()
                .Property("UF")
                .HasColumnName("uf")
                .HasColumnType("char(2)")
                .IsRequired();

            modelBuilder.Entity<Cidade>()
               .Property("CidadeId")
               .HasColumnName("CidadeId")
               .HasColumnType("varchar(20)")
               .IsRequired();

            modelBuilder.Entity<Cidade>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
              .ToTable("Cliente")
              .HasKey("ClienteID");

            modelBuilder.Entity<Cliente>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Cliente>()
               .Property("Telefone")
               .HasColumnName("telefone")
               .HasColumnType("varchar(20)")
               .IsRequired();

            modelBuilder.Entity<Cliente>()
               .Property("Email")
               .HasColumnName("Email")
               .HasColumnType("varchar(200)")
               .IsRequired();

            modelBuilder.Entity<Cliente>()
             .Property("Cpf")
             .HasColumnName("Cpf")
             .HasColumnType("char(11)")
             .IsRequired();

            //////////////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity<Bar>()
             .ToTable("Bar")
             .HasKey("BarID");

            modelBuilder.Entity<Bar>()
                .Property("Nome")
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Bar>()
               .Property("cnpj")
               .HasColumnName("cnpj")
               .HasColumnType("int")
               .IsRequired();

            modelBuilder.Entity<Bar>()
               .Property("Restricao")
               .HasColumnName("Restricao")
               .HasColumnType("varchar(100)")
               .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("horario")
             .HasColumnName("horario")
             .HasColumnType("DateTime")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("Capacidade")
             .HasColumnName("Capacidade")
             .HasColumnType("int")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("Localizacao")
             .HasColumnName("Localizacao")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("Numero")
             .HasColumnName("Numero")
             .HasColumnType("varchar(100)")
             .IsRequired();

            modelBuilder.Entity<Bar>()
             .Property("Cep")
             .HasColumnName("Cep")
             .HasColumnType("char(8)")
             .IsRequired();

            ////////////////////////////////////////////////////////////////


            base.OnModelCreating(modelBuilder);
        }
    }
}
