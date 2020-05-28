using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteTec.Domain.Entities;
using TesteTec.Infra.Data.Mappings;

namespace TesteTec.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Rick> Ricks { get; set; }
        //public DbSet<Morty> Morties { get; set; }
        public DbSet<Dimensao> Dimensao { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ViagemMap());
            modelBuilder.ApplyConfiguration(new RickMap());
            modelBuilder.ApplyConfiguration(new MortyMap());
            modelBuilder.ApplyConfiguration(new DimensaoMap());
            modelBuilder.Entity<Morty>(b =>
            {
                b.HasData(
                    new
                    {
                        Id = (int)1
                    },
                     new
                     {
                         Id = (int)2
                     },
                      new
                      {
                          Id = (int)3
                      },
                     new
                     {
                         Id = (int)4
                     }
                    );
            });
            modelBuilder.Entity<Dimensao>(b =>
            {
                b.HasData(
                    new
                    {
                        Id = (int)1,
                        NomeDimensao = "C001"
                    },
                     new
                     {
                         Id = (int)2,
                         NomeDimensao = "C002"
                     },
                      new
                      {
                          Id = (int)3,
                          NomeDimensao = "C003"
                      },
                       new
                       {
                           Id = (int)4,
                           NomeDimensao = "C137"
                       }
                    );
            });
            modelBuilder.Entity<Rick>(b =>
            {
                b.HasData(
                new
                {
                    Id = (int)1,
                    IdDimensao = (int)1,
                    IdMorty = (int)1
                },
                new
                {
                    Id = (int)2,
                    IdDimensao = (int)2,
                    IdMorty = (int)2,
                },
                new
                {
                    Id = (int)3,
                    IdDimensao = (int)3,
                    IdMorty = (int)3,
                },
                new
                {
                    Id = (int)4,
                    IdDimensao = (int)4,
                    IdMorty = (int)4,
                });
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
