using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class SeedingProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Email);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Category", "Image", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Apple", "smartphones", "https://i.dummyjson.com/data/products/1/thumbnail.jpg", 549, "iPhone 9" },
                    { 2, "Apple", "smartphones", "https://i.dummyjson.com/data/products/2/thumbnail.jpg", 899, "iPhone X" },
                    { 3, "Samsung", "smartphones", "https://i.dummyjson.com/data/products/3/thumbnail.jpg", 1249, "Samsung Universe 9" },
                    { 4, "OPPO", "smartphones", "https://i.dummyjson.com/data/products/4/thumbnail.jpg", 280, "OPPOF19" },
                    { 5, "Huawei", "smartphones", "https://i.dummyjson.com/data/products/5/thumbnail.jpg", 499, "Huawei P30" },
                    { 6, "Apple", "laptops", "https://i.dummyjson.com/data/products/6/thumbnail.png", 1749, "MacBook Pro" },
                    { 7, "Samsung", "laptops", "https://i.dummyjson.com/data/products/7/thumbnail.jpg", 1499, "Samsung Galaxy Book" },
                    { 8, "Microsoft Surface", "laptops", "https://i.dummyjson.com/data/products/8/thumbnail.jpg", 1499, "Microsoft Surface Laptop 4" },
                    { 9, "Infinix", "laptops", "https://i.dummyjson.com/data/products/9/thumbnail.jpg", 1099, "Infinix INBOOK" },
                    { 10, "HP Pavilion", "laptops", "https://i.dummyjson.com/data/products/10/thumbnail.jpeg", 1099, "HP Pavilion 15-DK1056WM" },
                    { 11, "Impression of Acqua Di Gio", "fragrances", "https://i.dummyjson.com/data/products/11/thumbnail.jpg", 13, "perfume Oil" },
                    { 12, "Royal_Mirage", "fragrances", "https://i.dummyjson.com/data/products/12/thumbnail.jpg", 40, "Brown Perfume" },
                    { 13, "Fog Scent Xpressio", "fragrances", "https://i.dummyjson.com/data/products/13/thumbnail.webp", 13, "Fog Scent Xpressio Perfume" },
                    { 14, "Al Munakh", "fragrances", "https://i.dummyjson.com/data/products/14/thumbnail.jpg", 120, "Non-Alcoholic Concentrated Perfume Oil" },
                    { 15, "Lord - Al-Rehab", "fragrances", "https://i.dummyjson.com/data/products/15/thumbnail.jpg", 30, "Eau De Perfume Spray" },
                    { 16, "L'Oreal Paris", "skincare", "https://i.dummyjson.com/data/products/16/thumbnail.jpg", 19, "Hyaluronic Acid Serum" },
                    { 17, "Hemani Tea", "skincare", "https://i.dummyjson.com/data/products/17/thumbnail.jpg", 12, "Tree Oil 30ml" },
                    { 18, "Dermive", "skincare", "https://i.dummyjson.com/data/products/18/thumbnail.jpg", 40, "Oil Free Moisturizer 100ml" },
                    { 19, "ROREC White Rice", "skincare", "https://i.dummyjson.com/data/products/19/thumbnail.jpg", 46, "Skin Beauty Serum." },
                    { 20, "Fair & Clear", "skincare", "https://i.dummyjson.com/data/products/20/thumbnail.jpg", 70, "Freckle Treatment Cream- 15gm" },
                    { 21, "Saaf & Khaas", "groceries", "https://i.dummyjson.com/data/products/21/thumbnail.png", 20, "- Daal Masoor 500 grams" },
                    { 22, "Bake Parlor Big", "groceries", "https://i.dummyjson.com/data/products/22/thumbnail.jpg", 14, "Elbow Macaroni - 400 gm" },
                    { 23, "Baking Food Items", "groceries", "https://i.dummyjson.com/data/products/23/thumbnail.jpg", 14, "Orange Essence Food Flavou" },
                    { 24, "fauji", "groceries", "https://i.dummyjson.com/data/products/24/thumbnail.jpg", 46, "cereals muesli fruit nuts" },
                    { 25, "Dry Rose", "groceries", "https://i.dummyjson.com/data/products/25/thumbnail.jpg", 70, "Gulab Powder 50 Gram" },
                    { 26, "Boho Decor", "home-decoration", "https://i.dummyjson.com/data/products/26/thumbnail.jpg", 41, "Plant Hanger For Home" },
                    { 27, "Flying Wooden", "home-decoration", "https://i.dummyjson.com/data/products/27/thumbnail.webp", 51, "Flying Wooden Bird" },
                    { 28, "LED Lights", "home-decoration", "https://i.dummyjson.com/data/products/28/thumbnail.jpg", 20, "3D Embellishment Art Lamp" },
                    { 29, "luxury palace", "home-decoration", "https://i.dummyjson.com/data/products/29/thumbnail.webp", 60, "Handcraft Chinese style" },
                    { 30, "Golden", "home-decoration", "https://i.dummyjson.com/data/products/30/thumbnail.jpg", 30, "Key Holder" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
