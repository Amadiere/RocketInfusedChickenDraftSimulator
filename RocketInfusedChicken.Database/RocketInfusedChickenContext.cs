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
        public DbSet<CardColor> CardColors { get; set; }
        public DbSet<CardSpellType> CardSpellTypes { get; set; }
        public DbSet<CardSpellSubType> CardSpellSubTypes { get; set; }
        public DbSet<CardSpellSuperType> CardSpellSuperTypes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Draft> Drafts { get; set; }
        public DbSet<DraftPlayer> DraftPlayers { get; set; }
        public DbSet<Pack> Packs { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Printing> Printings { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<SpellType> SpellTypes { get; set; }
        public DbSet<SpellSubType> SpellSubTypes { get; set; }
        public DbSet<SpellSuperType> SpellSuperTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Printings
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

            // Colours
            modelBuilder.Entity<CardColor>()
                .HasKey(cc => new { cc.CardId, cc.ColorId });

            modelBuilder.Entity<CardColor>()
                .HasOne(cc => cc.Card)
                .WithMany(s => s.CardColors)
                .HasForeignKey(cc => cc.CardId);

            modelBuilder.Entity<CardColor>()
                .HasOne(cc => cc.Color)
                .WithMany(s => s.CardColors)
                .HasForeignKey(cc => cc.ColorId);

            // SuperTypes
            modelBuilder.Entity<CardSpellSuperType>()
                .HasKey(cc => new { cc.CardId, cc.SpellSuperTypeId });

            modelBuilder.Entity<CardSpellSuperType>()
                .HasOne(cc => cc.Card)
                .WithMany(s => s.SuperTypes)
                .HasForeignKey(cc => cc.CardId);

            modelBuilder.Entity<CardSpellSuperType>()
                .HasOne(cc => cc.SpellSuperType)
                .WithMany(s => s.CardSuperTypes)
                .HasForeignKey(cc => cc.SpellSuperTypeId);

            // SubTypes
            modelBuilder.Entity<CardSpellSubType>()
                .HasKey(cc => new { cc.CardId, cc.SpellSubTypeId });

            modelBuilder.Entity<CardSpellSubType>()
                .HasOne(cc => cc.Card)
                .WithMany(s => s.SubTypes)
                .HasForeignKey(cc => cc.CardId);

            modelBuilder.Entity<CardSpellSubType>()
                .HasOne(cc => cc.SpellSubType)
                .WithMany(s => s.CardSubTypes)
                .HasForeignKey(cc => cc.SpellSubTypeId);

            // Types
            modelBuilder.Entity<CardSpellType>()
                .HasKey(cc => new { cc.CardId, cc.SpellTypeId });

            modelBuilder.Entity<CardSpellType>()
                .HasOne(cc => cc.Card)
                .WithMany(s => s.Types)
                .HasForeignKey(cc => cc.CardId);

            modelBuilder.Entity<CardSpellType>()
                .HasOne(cc => cc.SpellType)
                .WithMany(s => s.CardTypes)
                .HasForeignKey(cc => cc.SpellTypeId);




            modelBuilder.Entity<Color>().HasData(
                new Color() { Id = 1, Name = "White", ShortCode = "W" },
                new Color() { Id = 2, Name = "Black", ShortCode = "B" },
                new Color() { Id = 3, Name = "Blue", ShortCode = "U" },
                new Color() { Id = 4, Name = "Green", ShortCode = "G" },
                new Color() { Id = 5, Name = "Red", ShortCode = "R" }
            );

            modelBuilder.Entity<SpellType>().HasData(
                new SpellType() { Id = 1, Name = "Artifact" },
                new SpellType() { Id = 2, Name = "Creature" },
                new SpellType() { Id = 3, Name = "Enchantment" },
                new SpellType() { Id = 4, Name = "Instant" },
                new SpellType() { Id = 5, Name = "Land" },
                new SpellType() { Id = 6, Name = "Planeswalker" },
                new SpellType() { Id = 7, Name = "Scheme" },
                new SpellType() { Id = 8, Name = "Sorcery" }
            );

            modelBuilder.Entity<SpellSuperType>().HasData(
                new SpellSuperType() { Id = 1, Name = "Basic" },
                new SpellSuperType() { Id = 2, Name = "Legendary" },
                new SpellSuperType() { Id = 3, Name = "Ongoing" },
                new SpellSuperType() { Id = 4, Name = "Snow" },
                new SpellSuperType() { Id = 5, Name = "World" }
            );

            modelBuilder.Entity<SpellSubType>().HasData(
                new SpellSubType() { Id = 1, Name = "Angel" },
                new SpellSubType() { Id = 2, Name = "Vampire" },
                new SpellSubType() { Id = 3, Name = "Zombie" },
                new SpellSubType() { Id = 4, Name = "Wizard" },
                new SpellSubType() { Id = 5, Name = "Human" }
            );

            modelBuilder.Entity<Set>().HasData(
                new Set() { Id = 33, Name = "Guilds of Shropshire", Code = "GOS", ReleaseDate = DateTime.Now },
                new Set() { Id = 51, Name = "Innastruggle", Code = "INS", ReleaseDate = DateTime.Now.AddMonths(-19) }
            );

            modelBuilder.Entity<Card>().HasData(
                new Card() { Id = 1, MultiverseId = 1000, Name = "Alex Rocks" },
                new Card() { Id = 2, MultiverseId = 666, Name = "Sammer Smells" }
            );

            modelBuilder.Entity<CardSpellType>().HasData(
                new CardSpellType() { CardId = 1, SpellTypeId = 2 },
                new CardSpellType() { CardId = 1, SpellTypeId = 3 },
                new CardSpellType() { CardId = 2, SpellTypeId = 2 },
                new CardSpellType() { CardId = 2, SpellTypeId = 1 }
            );

            modelBuilder.Entity<CardSpellSuperType>().HasData(
                new CardSpellSuperType() { CardId = 1, SpellSuperTypeId = 2 }
            );

            modelBuilder.Entity<CardSpellSubType>().HasData(
                new CardSpellSubType() { CardId = 1, SpellSubTypeId = 2 },
                new CardSpellSubType() { CardId = 2, SpellSubTypeId = 5 },
                new CardSpellSubType() { CardId = 2, SpellSubTypeId = 4 }
            );

            modelBuilder.Entity<Printing>().HasData(
                new Printing() { CardId = 1, SetId = 33 },
                new Printing() { CardId = 2, SetId = 33 },
                new Printing() { CardId = 1, SetId = 51 }
            );
        }
    }
}
