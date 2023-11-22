using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;

namespace crudWeb_Martha24Bm.Models
{
    public partial class ProgramacionContext : DbContext
    {
        public ProgramacionContext()
        {
        }

        public ProgramacionContext(DbContextOptions<ProgramacionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
              //  optionsBuilder.UseSqlServer("server=USER-PC\\MSSQLSERVER01; database=Programacion; integrated security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property<int>("Id")
                         .ValueGeneratedOnAdd()
                         .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(entity.Property<int>("Id"));


                entity.Property<string>("Nombre")
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property<string>("Titulo")
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property<string>("Descripcion")
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property<string>("PaginaWeb")
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property<string>("Telefono")
                    .IsRequired()
                    .HasColumnType("varchar(50)");

                entity.Property<string>("Encabezado")
                    .HasColumnType("varchar(50)");

                entity.Property<string>("Texto")
                    .HasColumnType("varchar(50)");

                entity.Property<string>("EncabezadoW")
                    .HasColumnType("varchar(50)");

                entity.Property<string>("TextoW")
                    .HasColumnType("varchar(50)");

                entity.Property<int?>("html")
                        .HasColumnType("int");

                entity.Property<int?>("css")
                        .HasColumnType("int");
                entity.Property<int?>("js")
                        .HasColumnType("int");
                entity.Property<int?>("wp")
                        .HasColumnType("int");
                entity.Property<int?>("photo")
                        .HasColumnType("int");
                entity.Property<int?>("php")
                        .HasColumnType("int"); 
                entity.Property<int?>("linux")
                        .HasColumnType("int");
                entity.Property<int?>("seo")
                        .HasColumnType("int");


            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
