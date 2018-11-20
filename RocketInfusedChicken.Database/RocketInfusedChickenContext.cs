using Microsoft.EntityFrameworkCore;
using RocketInfusedChicken.Database.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RocketInfusedChicken.Database
{
    public class RocketInfusedChickenContext : DbContext
    {
        public RocketInfusedChickenContext(DbContextOptions<RocketInfusedChickenContext> options) : base(options)
        {

        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Draft> Drafts { get; set; }
        public DbSet<DraftPlayer> DraftPlayers { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Printing> Printings { get; set; }
        public DbSet<Set> Sets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Printing>()
                .HasKey(p => new { p.CardId, p.SetId });

            modelBuilder.Entity<Printing>()
                .HasOne(p => p.Set)
                .WithMany(s => s.Printings)
                .HasForeignKey(p => p.SetId);

            modelBuilder.Entity<Printing>()
                .HasOne(p => p.Card)
                .WithMany(c => c.Printings)
                .HasForeignKey(p => p.CardId);


            modelBuilder.Entity<Card>().HasData(
                new Card() { Id = 1, MultiverseId = 1000, Name = "Alex Rocks" },
                new Card() { Id = 2, MultiverseId = 666, Name = "Sammer Smells" }
            );

            modelBuilder.Entity<Set>().HasData(
                new Set() { Id = 33, Name = "Guilds of Shropshire", Code = "GOS", ReleaseDate = DateTime.Now },
                new Set() { Id = 51, Name = "Innastruggle", Code = "INS", ReleaseDate = DateTime.Now.AddMonths(-19) }
            );

            modelBuilder.Entity<Printing>().HasData(
                new Printing() { CardId = 1, SetId = 33 },
                new Printing() { CardId = 2, SetId = 33 },
                new Printing() { CardId = 1, SetId = 51 }
            );
        }
    }
}
