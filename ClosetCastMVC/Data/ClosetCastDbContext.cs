using ClosetCastMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ClosetCastMVC.Data
{
    public class ClosetCastDbContext : DbContext
    {
        public ClosetCastDbContext(DbContextOptions<ClosetCastDbContext> options) : base(options)
        {


        }

        public DbSet<ClothingItem> ClothingItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClothingItem>().HasData(
                // TOP ITEMS
                new ClothingItem
                {
                    ClothingItemId = 1,
                    Name = "White T-Shirt",
                    Description = "Plain cotton crew neck t-shirt.",
                    Category = "Top",
                    WarmthLevel = 1,
                    IsWaterproof = false,
                    Price = 12.99m,
                    DatePurchased = new DateTime(2025, 6, 2)
                },
                new ClothingItem
                {
                    ClothingItemId = 2,
                    Name = "Tank Top",
                    Description = "Lightweight tank top for hot days.",
                    Category = "Top",
                    WarmthLevel = 1,
                    IsWaterproof = false,
                    Price = 9.99m,
                    DatePurchased = new DateTime(2025, 7, 14)
                },
                new ClothingItem
                {
                    ClothingItemId = 3,
                    Name = "Long Sleeve Tee",
                    Description = "Soft long sleeve cotton shirt.",
                    Category = "Top",
                    WarmthLevel = 2,
                    IsWaterproof = false,
                    Price = 18.99m,
                    DatePurchased = new DateTime(2024, 9, 20)
                },
                new ClothingItem
                {
                    ClothingItemId = 4,
                    Name = "Flannel Shirt",
                    Description = "Red and black plaid flannel button-up.",
                    Category = "Top",
                    WarmthLevel = 3,
                    IsWaterproof = false,
                    Price = 29.99m,
                    DatePurchased = new DateTime(2024, 10, 5)
                },
                new ClothingItem
                {
                    ClothingItemId = 5,
                    Name = "WVU Hoodie",
                    Description = "Gold and blue pullover hoodie.",
                    Category = "Top",
                    WarmthLevel = 3,
                    IsWaterproof = false,
                    Price = 49.99m,
                    DatePurchased = new DateTime(2025, 8, 25)
                },
                new ClothingItem
                {
                    ClothingItemId = 6,
                    Name = "Wool Sweater",
                    Description = "Thick knit wool sweater.",
                    Category = "Top",
                    WarmthLevel = 4,
                    IsWaterproof = false,
                    Price = 59.99m,
                    DatePurchased = new DateTime(2023, 12, 1)
                },
                new ClothingItem
                {
                    ClothingItemId = 7,
                    Name = "Thermal Base Layer",
                    Description = "Warm thermal shirt to wear under layers.",
                    Category = "Top",
                    WarmthLevel = 5,
                    IsWaterproof = false,
                    Price = 34.99m,
                    DatePurchased = new DateTime(2024, 1, 15)
                },
                // BOTTOM ITEMS
                new ClothingItem
                {
                    ClothingItemId = 8,
                    Name = "Khaki Shorts",
                    Description = "Casual khaki shorts.",
                    Category = "Bottom",
                    WarmthLevel = 1,
                    IsWaterproof = false,
                    Price = 24.99m,
                    DatePurchased = new DateTime(2025, 5, 10)
                },
                new ClothingItem
                {
                    ClothingItemId = 9,
                    Name = "Athletic Shorts",
                    Description = "Breathable shorts for working out.",
                    Category = "Bottom",
                    WarmthLevel = 1,
                    IsWaterproof = false,
                    Price = 19.99m,
                    DatePurchased = new DateTime(2025, 4, 3)
                },
                new ClothingItem
                {
                    ClothingItemId = 10,
                    Name = "Joggers",
                    Description = "Comfortable cotton jogger pants.",
                    Category = "Bottom",
                    WarmthLevel = 2,
                    IsWaterproof = false,
                    Price = 34.99m,
                    DatePurchased = new DateTime(2025, 2, 18)
                },
                new ClothingItem
                {
                    ClothingItemId = 11,
                    Name = "Blue Jeans",
                    Description = "Classic straight fit denim jeans.",
                    Category = "Bottom",
                    WarmthLevel = 3,
                    IsWaterproof = false,
                    Price = 44.99m,
                    DatePurchased = new DateTime(2024, 8, 30)
                },
                new ClothingItem
                {
                    ClothingItemId = 12,
                    Name = "Rain Pants",
                    Description = "Waterproof pants that pull over other pants.",
                    Category = "Bottom",
                    WarmthLevel = 3,
                    IsWaterproof = true,
                    Price = 39.99m,
                    DatePurchased = new DateTime(2024, 3, 22)
                },
                new ClothingItem
                {
                    ClothingItemId = 13,
                    Name = "Corduroy Pants",
                    Description = "Thick brown corduroy pants.",
                    Category = "Bottom",
                    WarmthLevel = 4,
                    IsWaterproof = false,
                    Price = 42.99m,
                    DatePurchased = new DateTime(2023, 11, 11)
                },
                new ClothingItem
                {
                    ClothingItemId = 14,
                    Name = "Fleece-Lined Pants",
                    Description = "Pants with a warm fleece lining.",
                    Category = "Bottom",
                    WarmthLevel = 5,
                    IsWaterproof = false,
                    Price = 49.99m,
                    DatePurchased = new DateTime(2024, 12, 6)
                },
                // OUTERWEAR ITEMS
                new ClothingItem
                {
                    ClothingItemId = 15,
                    Name = "Windbreaker",
                    Description = "Thin jacket that blocks the wind.",
                    Category = "Outerwear",
                    WarmthLevel = 2,
                    IsWaterproof = false,
                    Price = 39.99m,
                    DatePurchased = new DateTime(2025, 3, 9)
                },
                new ClothingItem
                {
                    ClothingItemId = 16,
                    Name = "Light Rain Jacket",
                    Description = "Packable waterproof rain jacket.",
                    Category = "Outerwear",
                    WarmthLevel = 2,
                    IsWaterproof = true,
                    Price = 54.99m,
                    DatePurchased = new DateTime(2025, 4, 21)
                },
                new ClothingItem
                {
                    ClothingItemId = 17,
                    Name = "Denim Jacket",
                    Description = "Classic blue jean jacket.",
                    Category = "Outerwear",
                    WarmthLevel = 3,
                    IsWaterproof = false,
                    Price = 59.99m,
                    DatePurchased = new DateTime(2024, 9, 1)
                },
                new ClothingItem
                {
                    ClothingItemId = 18,
                    Name = "Waterproof Shell Jacket",
                    Description = "Hooded waterproof jacket for cool rainy days.",
                    Category = "Outerwear",
                    WarmthLevel = 3,
                    IsWaterproof = true,
                    Price = 89.99m,
                    DatePurchased = new DateTime(2024, 10, 19)
                },
                new ClothingItem
                {
                    ClothingItemId = 19,
                    Name = "Fleece Jacket",
                    Description = "Warm zip-up fleece jacket.",
                    Category = "Outerwear",
                    WarmthLevel = 4,
                    IsWaterproof = false,
                    Price = 49.99m,
                    DatePurchased = new DateTime(2023, 10, 28)
                },
                new ClothingItem
                {
                    ClothingItemId = 20,
                    Name = "Puffer Coat",
                    Description = "Heavy insulated waterproof winter coat.",
                    Category = "Outerwear",
                    WarmthLevel = 5,
                    IsWaterproof = true,
                    Price = 149.99m,
                    DatePurchased = new DateTime(2023, 11, 24)
                },
                // SHOES ITEMS
                new ClothingItem
                {
                    ClothingItemId = 21,
                    Name = "Sandals",
                    Description = "Open-toe sandals for summer.",
                    Category = "Shoes",
                    WarmthLevel = 1,
                    IsWaterproof = false,
                    Price = 29.99m,
                    DatePurchased = new DateTime(2025, 6, 15)
                },
                new ClothingItem
                {
                    ClothingItemId = 22,
                    Name = "Waterproof Slides",
                    Description = "Rubber slides that can get wet.",
                    Category = "Shoes",
                    WarmthLevel = 1,
                    IsWaterproof = true,
                    Price = 19.99m,
                    DatePurchased = new DateTime(2025, 7, 4)
                },
                new ClothingItem
                {
                    ClothingItemId = 23,
                    Name = "Running Sneakers",
                    Description = "Breathable mesh running shoes.",
                    Category = "Shoes",
                    WarmthLevel = 2,
                    IsWaterproof = false,
                    Price = 89.99m,
                    DatePurchased = new DateTime(2025, 1, 12)
                },
                new ClothingItem
                {
                    ClothingItemId = 24,
                    Name = "Canvas Sneakers",
                    Description = "Casual low-top canvas shoes.",
                    Category = "Shoes",
                    WarmthLevel = 2,
                    IsWaterproof = false,
                    Price = 54.99m,
                    DatePurchased = new DateTime(2024, 5, 8)
                },
                new ClothingItem
                {
                    ClothingItemId = 25,
                    Name = "Rain Boots",
                    Description = "Rubber boots for puddles and mud.",
                    Category = "Shoes",
                    WarmthLevel = 3,
                    IsWaterproof = true,
                    Price = 44.99m,
                    DatePurchased = new DateTime(2024, 4, 2)
                },
                new ClothingItem
                {
                    ClothingItemId = 26,
                    Name = "Leather Boots",
                    Description = "Brown leather ankle boots.",
                    Category = "Shoes",
                    WarmthLevel = 3,
                    IsWaterproof = false,
                    Price = 119.99m,
                    DatePurchased = new DateTime(2023, 9, 16)
                },
                new ClothingItem
                {
                    ClothingItemId = 27,
                    Name = "Waterproof Hiking Boots",
                    Description = "Hiking boots with a waterproof lining.",
                    Category = "Shoes",
                    WarmthLevel = 4,
                    IsWaterproof = true,
                    Price = 129.99m,
                    DatePurchased = new DateTime(2024, 10, 1)
                },
                new ClothingItem
                {
                    ClothingItemId = 28,
                    Name = "Winter Snow Boots",
                    Description = "Insulated boots with good grip for snow and ice.",
                    Category = "Shoes",
                    WarmthLevel = 5,
                    IsWaterproof = true,
                    Price = 99.99m,
                    DatePurchased = new DateTime(2023, 12, 20)
                },
                // ACCESSORY ITEMS
                new ClothingItem
                {
                    ClothingItemId = 29,
                    Name = "Sunglasses",
                    Description = "Polarized sunglasses.",
                    Category = "Accessory",
                    WarmthLevel = 1,
                    IsWaterproof = false,
                    Price = 24.99m,
                    DatePurchased = new DateTime(2025, 5, 27)
                },
                new ClothingItem
                {
                    ClothingItemId = 30,
                    Name = "Baseball Cap",
                    Description = "WVU baseball cap.",
                    Category = "Accessory",
                    WarmthLevel = 2,
                    IsWaterproof = false,
                    Price = 22.99m,
                    DatePurchased = new DateTime(2024, 8, 17)
                },
                new ClothingItem
                {
                    ClothingItemId = 31,
                    Name = "Umbrella",
                    Description = "Compact folding umbrella.",
                    Category = "Accessory",
                    WarmthLevel = 3,
                    IsWaterproof = true,
                    Price = 14.99m,
                    DatePurchased = new DateTime(2024, 3, 30)
                },
                new ClothingItem
                {
                    ClothingItemId = 32,
                    Name = "Knit Beanie",
                    Description = "Warm knit winter hat.",
                    Category = "Accessory",
                    WarmthLevel = 4,
                    IsWaterproof = false,
                    Price = 16.99m,
                    DatePurchased = new DateTime(2023, 11, 2)
                },
                new ClothingItem
                {
                    ClothingItemId = 33,
                    Name = "Winter Gloves",
                    Description = "Insulated waterproof gloves.",
                    Category = "Accessory",
                    WarmthLevel = 5,
                    IsWaterproof = true,
                    Price = 29.99m,
                    DatePurchased = new DateTime(2023, 12, 10)
                },
                new ClothingItem
                {
                    ClothingItemId = 34,
                    Name = "Wool Scarf",
                    Description = "Long warm wool scarf.",
                    Category = "Accessory",
                    WarmthLevel = 5,
                    IsWaterproof = false,
                    Price = 19.99m,
                    DatePurchased = new DateTime(2024, 1, 5)
                }
            );
        }
    }
}
