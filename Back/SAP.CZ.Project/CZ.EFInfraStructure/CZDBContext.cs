using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using static System.Collections.Specialized.BitVector32;
using System.Reflection.Emit;
using CZ.Domain;

namespace Cz.Project.EFInfraStructure
{
    public class CZDBContext : DbContext
    {
        public CZDBContext() { }
        public CZDBContext(DbContextOptions<CZDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=./;Initial Catalog=SAP.CZ.Project;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<LicenseLicense>(l =>
            // {
            //     l.HasNoKey();
            // });

            // ConfigureUniqueIndexes(modelBuilder);
            // ConfigureDefaultValues(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void ConfigureDefaultValues(ModelBuilder modelBuilder)
        {
        }

        // public override int SaveChanges()
        // {
        //     // var entities = ChangeTracker.Entries()
        //     //     .Where(x => x.Entity is KeyEntity && (x.State == EntityState.Added));
        //     // 
        //     // foreach (var entity in entities)
        //     //     ((KeyEntity)entity.Entity).Key = Guid.NewGuid().ToString();
        //     // 
        //     // return base.SaveChanges();
        // }

        private void ConfigureUniqueIndexes(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Order>()
            //     .HasIndex(x => x.Key);
        }
    }
}
