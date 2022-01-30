﻿using ComicStore.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComicStore.DAL.Context
{
    public class ComicContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = "host=localhost;port=5432;database=comicstore;username=postgres;password=Master117+";
            optionsBuilder.UseNpgsql(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity => 
            {
                entity.HasKey(c => c.Id)
                      .HasName("PK_tbCategoria");

                entity.ToTable("categorias");
                
                entity.Property(c => c.Id)
                      .HasColumnName("idCategoria")
                      .UseIdentityByDefaultColumn();
                
                entity.Property(c => c.Nombre)
                      .HasColumnName("nombre")
                      .HasMaxLength(50);
            });
        }

        #region DBSETS
        public virtual DbSet<Categoria> Categorias{ get; set; }
        public virtual DbSet<Comic> Comics{ get; set; }
        #endregion
    }
}