﻿using GG1RKK_HFT_202324.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GG1RKK_HFT_2023241.Repository.Database
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Adventurer> Adventurers { get; set; }
        public ShopDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseLazyLoadingProxies().UseInMemoryDatabase("shop");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adventurer>().HasData(new Adventurer[]
            {
                new Adventurer { AdventurerId = 1, Name = "Jake the Dog", Class = "Druid", Level = 5 },
                new Adventurer { AdventurerId = 2, Name = "Elena Swiftblade", Class = "Rogue", Level = 12 },
                new Adventurer { AdventurerId = 3, Name = "Finn the Human", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 4, Name = "Sir Gareth Ironheart", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 5, Name = "Lyria Moonshadow", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 6, Name = "Thorin Stoneshield", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 7, Name = "Luna Silverwind", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 8, Name = "Aria Lightbringer", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 9, Name = "Grimm Blackthorn", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 10, Name = "Morgana Shadowbane", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 11, Name = "Brutus Ironfist", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 12, Name = "Seraphina Frostheart", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 13, Name = "Kai Swiftstrike", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 14, Name = "Isolde Stormcaller", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 15, Name = "Cassius Darkmoon", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 16, Name = "Faelan Shadowstep", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 17, Name = "Eowyn Stormbringer", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 18, Name = "Aldric Trueheart", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 19, Name = "Elara Emberheart", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 20, Name = "Thrain Thunderaxe", Class = "Fighter", Level = 10 },
                new Adventurer { AdventurerId = 21, Name = "Sylas Moonfire", Class = "Fighter", Level = 10 }
            });


            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new Category {CategoryId = 1, CategoryName = "Weapons"},
                new Category {CategoryId = 2, CategoryName = "Magic Items"},
                new Category {CategoryId = 3, CategoryName = "Accessories"},
                new Category {CategoryId = 4, CategoryName = "Armaments"},
                new Category {CategoryId = 5, CategoryName = "Tools"},
            });

            modelBuilder.Entity<Item>().HasData(new Item[]
            {
                // Weapons
                new Item {ItemId = 1, ItemName = "Claymore", CategoryId = 1, Price = 100 },
                new Item {ItemId = 2, ItemName = "Blazing Sword", CategoryId = 1, Price = 150 },
                new Item {ItemId = 3, ItemName = "Cursed Dagger", CategoryId = 1, Price = 60 },
                new Item {ItemId = 4, ItemName = "Thunderstone Hammer", CategoryId = 1, Price = 200 },
                new Item {ItemId = 5, ItemName = "Venomous Dagger", CategoryId = 1, Price = 70 },
                new Item {ItemId = 6, ItemName = "Elven Bow", CategoryId = 1, Price = 150 },
                new Item {ItemId = 7, ItemName = "Silent Bow", CategoryId = 1, Price = 200 },
                new Item {ItemId = 8, ItemName = "Dagger of Shadows", CategoryId = 1, Price = 80 },
                new Item {ItemId = 9, ItemName = "Longsword", CategoryId = 1, Price = 120 },
                new Item {ItemId = 10, ItemName = "Battle Axe", CategoryId = 1, Price = 180 },

                // Magic Items
                new Item {ItemId = 11, ItemName = "Rune Staff", CategoryId = 2, Price = 250 },
                new Item {ItemId = 12, ItemName = "Sorcerer's Spellbook", CategoryId = 2, Price = 180 },
                new Item {ItemId = 13, ItemName = "Ring of Shadows", CategoryId = 2, Price = 300 },
                new Item {ItemId = 14, ItemName = "Cloak of Shadows", CategoryId = 2, Price = 300 },
                new Item {ItemId = 15, ItemName = "Staff of Time Manipulation", CategoryId = 2, Price = 700 },
                new Item {ItemId = 16, ItemName = "Wand of Ice", CategoryId = 2, Price = 160 },
                new Item {ItemId = 17, ItemName = "Lunar Staff", CategoryId = 2, Price = 600 },
                new Item {ItemId = 18, ItemName = "Scepter of Arcane Mastery", CategoryId = 2, Price = 900 },
                new Item {ItemId = 19, ItemName = "Mystic Crystal", CategoryId = 2, Price = 90 },
                new Item {ItemId = 20, ItemName = "Crystal Ball", CategoryId = 2, Price = 250 },
                new Item {ItemId = 21, ItemName = "Phoenix Feather Wand", CategoryId = 2, Price = 180 },

                // Accessories
                new Item {ItemId = 22, ItemName = "Celestial Ring", CategoryId = 3, Price = 150 },
                new Item {ItemId = 23, ItemName = "Legendary Helm", CategoryId = 3, Price = 500 },
                new Item {ItemId = 24, ItemName = "Amulet of Eternal Wisdom", CategoryId = 3, Price = 800 },
                new Item {ItemId = 25, ItemName = "Ancient Tome", CategoryId = 3, Price = 180 },
                new Item {ItemId = 26, ItemName = "Soulstone Amulet", CategoryId = 3, Price = 400 },
                new Item {ItemId = 27, ItemName = "Crystal Crown", CategoryId = 3, Price = 500 },
                new Item {ItemId = 28, ItemName = "Eagle Eye Amulet", CategoryId = 3, Price = 150 },
                new Item {ItemId = 29, ItemName = "Astral Compass", CategoryId = 3, Price = 120 },

                // Armaments
                new Item {ItemId = 30, ItemName = "Dragon Scale Armor", CategoryId = 4, Price = 300 },
                new Item {ItemId = 31, ItemName = "Aegis Shield", CategoryId = 4, Price = 300 },
                new Item {ItemId = 32, ItemName = "Helm of the Dragonborn", CategoryId = 4, Price = 600 },
                new Item {ItemId = 33, ItemName = "Dwarven Gauntlets", CategoryId = 4, Price = 120 },
                new Item {ItemId = 34, ItemName = "Steel Longsword", CategoryId = 4, Price = 180 },
                new Item {ItemId = 35, ItemName = "Plate Armor", CategoryId = 4, Price = 400 },
                new Item {ItemId = 36, ItemName = "Tower Shield", CategoryId = 4, Price = 350 },
                new Item {ItemId = 37, ItemName = "Chainmail", CategoryId = 4, Price = 200 },

                // Tools
                new Item {ItemId = 38, ItemName = "Potion of Invisibility", CategoryId = 5, Price = 50 },
                new Item {ItemId = 39, ItemName = "Enchanted Mirror", CategoryId = 5, Price = 180 },
                new Item {ItemId = 40, ItemName = "Mystic Crystal", CategoryId = 5, Price = 90 },
                new Item {ItemId = 41, ItemName = "Scepter of Elements", CategoryId = 5, Price = 1000 },
                new Item {ItemId = 42, ItemName = "Assassin's Cloak", CategoryId = 5, Price = 300 },
                new Item {ItemId = 43, ItemName = "Eagle Eye Amulet", CategoryId = 5, Price = 150 },
                new Item {ItemId = 44, ItemName = "Thief's Toolkit", CategoryId = 5, Price = 30 },
                new Item {ItemId = 45, ItemName = "Astral Compass", CategoryId = 5, Price = 120 },
            });

            //Orders
            modelBuilder.Entity<Order>().HasData(new Order[]
            {
                new Order { OrderId = 1, AdventurerId = 1, ItemId = 2 },
                new Order { OrderId = 2, AdventurerId = 1, ItemId = 8 },
                new Order { OrderId = 3, AdventurerId = 2, ItemId = 13 },
                new Order { OrderId = 4, AdventurerId = 3, ItemId = 18 },
                new Order { OrderId = 5, AdventurerId = 3, ItemId = 23 },
                new Order { OrderId = 6, AdventurerId = 4, ItemId = 28 },
                new Order { OrderId = 7, AdventurerId = 4, ItemId = 33 },
                new Order { OrderId = 8, AdventurerId = 5, ItemId = 3 },
                new Order { OrderId = 9, AdventurerId = 6, ItemId = 38 },
                new Order { OrderId = 10, AdventurerId = 6, ItemId = 43 },
                new Order { OrderId = 11, AdventurerId = 7, ItemId = 48 },
                new Order { OrderId = 12, AdventurerId = 7, ItemId = 1 },
                new Order { OrderId = 13, AdventurerId = 8, ItemId = 6 },
                new Order { OrderId = 14, AdventurerId = 8, ItemId = 11 },
                new Order { OrderId = 15, AdventurerId = 9, ItemId = 16 },
                new Order { OrderId = 16, AdventurerId = 10, ItemId = 21 },
                new Order { OrderId = 17, AdventurerId = 10, ItemId = 26 },
                new Order { OrderId = 18, AdventurerId = 11, ItemId = 31 },
                new Order { OrderId = 19, AdventurerId = 11, ItemId = 36 },
                new Order { OrderId = 20, AdventurerId = 12, ItemId = 41 },
                new Order { OrderId = 21, AdventurerId = 2, ItemId = 5 },
                new Order { OrderId = 22, AdventurerId = 3, ItemId = 10 },
                new Order { OrderId = 23, AdventurerId = 4, ItemId = 15 },
                new Order { OrderId = 24, AdventurerId = 5, ItemId = 20 },
                new Order { OrderId = 25, AdventurerId = 6, ItemId = 25 },
                new Order { OrderId = 26, AdventurerId = 7, ItemId = 30 },
                new Order { OrderId = 27, AdventurerId = 8, ItemId = 35 },
                new Order { OrderId = 28, AdventurerId = 9, ItemId = 40 },
                new Order { OrderId = 29, AdventurerId = 10, ItemId = 45 },
            });



        }
    }
}
