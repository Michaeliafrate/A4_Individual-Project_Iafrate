using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClosetCastMVC.Migrations
{
    /// <inheritdoc />
    public partial class addingSeedDataToClothingItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClothingItems",
                columns: new[] { "ClothingItemId", "Category", "DatePurchased", "Description", "IsWaterproof", "Name", "Price", "WarmthLevel" },
                values: new object[,]
                {
                    { 1, "Top", new DateTime(2025, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plain cotton crew neck t-shirt.", false, "White T-Shirt", 12.99m, 1 },
                    { 2, "Top", new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lightweight tank top for hot days.", false, "Tank Top", 9.99m, 1 },
                    { 3, "Top", new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Soft long sleeve cotton shirt.", false, "Long Sleeve Tee", 18.99m, 2 },
                    { 4, "Top", new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red and black plaid flannel button-up.", false, "Flannel Shirt", 29.99m, 3 },
                    { 5, "Top", new DateTime(2025, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gold and blue pullover hoodie.", false, "WVU Hoodie", 49.99m, 3 },
                    { 6, "Top", new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thick knit wool sweater.", false, "Wool Sweater", 59.99m, 4 },
                    { 7, "Top", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm thermal shirt to wear under layers.", false, "Thermal Base Layer", 34.99m, 5 },
                    { 8, "Bottom", new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casual khaki shorts.", false, "Khaki Shorts", 24.99m, 1 },
                    { 9, "Bottom", new DateTime(2025, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathable shorts for working out.", false, "Athletic Shorts", 19.99m, 1 },
                    { 10, "Bottom", new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comfortable cotton jogger pants.", false, "Joggers", 34.99m, 2 },
                    { 11, "Bottom", new DateTime(2024, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic straight fit denim jeans.", false, "Blue Jeans", 44.99m, 3 },
                    { 12, "Bottom", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Waterproof pants that pull over other pants.", true, "Rain Pants", 39.99m, 3 },
                    { 13, "Bottom", new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thick brown corduroy pants.", false, "Corduroy Pants", 42.99m, 4 },
                    { 14, "Bottom", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pants with a warm fleece lining.", false, "Fleece-Lined Pants", 49.99m, 5 },
                    { 15, "Outerwear", new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thin jacket that blocks the wind.", false, "Windbreaker", 39.99m, 2 },
                    { 16, "Outerwear", new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Packable waterproof rain jacket.", true, "Light Rain Jacket", 54.99m, 2 },
                    { 17, "Outerwear", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic blue jean jacket.", false, "Denim Jacket", 59.99m, 3 },
                    { 18, "Outerwear", new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hooded waterproof jacket for cool rainy days.", true, "Waterproof Shell Jacket", 89.99m, 3 },
                    { 19, "Outerwear", new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm zip-up fleece jacket.", false, "Fleece Jacket", 49.99m, 4 },
                    { 20, "Outerwear", new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy insulated waterproof winter coat.", true, "Puffer Coat", 149.99m, 5 },
                    { 21, "Shoes", new DateTime(2025, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Open-toe sandals for summer.", false, "Sandals", 29.99m, 1 },
                    { 22, "Shoes", new DateTime(2025, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rubber slides that can get wet.", true, "Waterproof Slides", 19.99m, 1 },
                    { 23, "Shoes", new DateTime(2025, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Breathable mesh running shoes.", false, "Running Sneakers", 89.99m, 2 },
                    { 24, "Shoes", new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casual low-top canvas shoes.", false, "Canvas Sneakers", 54.99m, 2 },
                    { 25, "Shoes", new DateTime(2024, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rubber boots for puddles and mud.", true, "Rain Boots", 44.99m, 3 },
                    { 26, "Shoes", new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brown leather ankle boots.", false, "Leather Boots", 119.99m, 3 },
                    { 27, "Shoes", new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hiking boots with a waterproof lining.", true, "Waterproof Hiking Boots", 129.99m, 4 },
                    { 28, "Shoes", new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insulated boots with good grip for snow and ice.", true, "Winter Snow Boots", 99.99m, 5 },
                    { 29, "Accessory", new DateTime(2025, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Polarized sunglasses.", false, "Sunglasses", 24.99m, 1 },
                    { 30, "Accessory", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "WVU baseball cap.", false, "Baseball Cap", 22.99m, 2 },
                    { 31, "Accessory", new DateTime(2024, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Compact folding umbrella.", true, "Umbrella", 14.99m, 3 },
                    { 32, "Accessory", new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Warm knit winter hat.", false, "Knit Beanie", 16.99m, 4 },
                    { 33, "Accessory", new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Insulated waterproof gloves.", true, "Winter Gloves", 29.99m, 5 },
                    { 34, "Accessory", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long warm wool scarf.", false, "Wool Scarf", 19.99m, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ClothingItems",
                keyColumn: "ClothingItemId",
                keyValue: 34);
        }
    }
}
