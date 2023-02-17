using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter.AB2A_Aufgabe_6
{
    internal class Context : DbContext
    {
        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<Lieferkosten> Lieferkosten { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-2IS8QAKV\\SQLEXPRESS;Database=AB2A_Aufgabe_6;Trusted_Connection=True;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kunde>().HasKey(k => k.ID);
            modelBuilder.Entity<Lieferkosten>().HasKey(l => l.ID);

            modelBuilder.Entity<Kunde>().HasOne(k => k.Lieferkosten)
                .WithMany(l => l.Kunden)
                .HasForeignKey(k => k.LieferkostenID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
