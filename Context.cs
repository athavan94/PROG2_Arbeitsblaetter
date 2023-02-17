using Microsoft.EntityFrameworkCore;
using PROG2_Arbeitsblaetter.AB2A_Aufgabe_6;
using PROG2_Arbeitsblaetter.AB2A_Aufgabe_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter
{
    internal class Context : DbContext
    {
        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<Lieferkosten> Lieferkosten { get; set; }
        public DbSet<ManchesterUnited> ManchesterUnited { get; set; }
        public DbSet<Player> Player { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-2IS8QAKV\\SQLEXPRESS;Database=AB2A_DB;Trusted_Connection=True;TrustServerCertificate=true;");
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

            modelBuilder.Entity<ManchesterUnited>().HasKey(m => m.ID);
            modelBuilder.Entity<Player>().HasKey(p => p.ID);

            modelBuilder.Entity<ManchesterUnited>().HasOne(m => m.Player)
                .WithMany(p => p.ManchesterUnited)
                .HasForeignKey(m => m.PlayerID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
