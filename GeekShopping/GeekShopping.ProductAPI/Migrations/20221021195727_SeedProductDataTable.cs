﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "CANECA", "Caneca R2D2", "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg", "Caneca R2D2", 39.9m },
                    { 2L, "CANECA", "Caneca R2D2", "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg", "Caneca R2D2", 39.9m },
                    { 3L, "CANECA", "Caneca R2D2", "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg", "Caneca R2D2", 39.9m },
                    { 4L, "CANECA", "Caneca R2D2", "D:\\Ricardo\\Cursos\\Udemy\\GeekShopping\\GeekShopping\\GeekShopping.ProductAPI\\Image\\41MIxdiEcDL._AC_.jpg", "Caneca R2D2", 39.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);
        }
    }
}
