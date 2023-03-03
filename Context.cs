using Microsoft.EntityFrameworkCore;
using PROG2_Arbeitsblaetter.AB2B_Aufgabe_8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2_Arbeitsblaetter
{
    internal class Context : DbContext
    {
        public DbSet<Team> Team { get; set; }
        public DbSet<Player> Player { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-2IS8QAKV\\SQLEXPRESS;Database=AB2A_DB;Trusted_Connection=True;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>().HasKey(t => t.ID);
            modelBuilder.Entity<Player>().HasKey(p => p.ID);

            modelBuilder.Entity<Player>().HasOne(p => p.Team)
                .WithMany(t => t.Player)
                .HasForeignKey(p => p.TeamID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Team>().HasData(
                new Team { ID = 1, Name = "Manchester United", Description = "Das beste Team der Welt!" },
                new Team { ID = 2, Name = "Chelsea", Description = "Gibt zu viel Geld aus :D" }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    ID = 1,
                    Name = "Rashford",
                    Vorname = "Marcus",
                    Nationalität = "England",
                    Position = "Linksaussen",
                    TeamID = 1
                },
                new Player
                {
                    ID = 2,
                    Name = "Pedri",
                    Vorname = "",
                    Nationalität = "Spanien",
                    Position = "Zentrales Mittelfeld",
                    TeamID = 2
                }
            );
        }

        public Team FindTeamByName(string name)
        {
            return this.Team.FirstOrDefault(t => t.Name == name);
        }

        public Player FindPlayerByName(string name)
        {
            return this.Player.FirstOrDefault(p => p.Name == name);
        }
    }
}
