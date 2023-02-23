﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Apple",
                            Category = "smartphones",
                            Image = "https://i.dummyjson.com/data/products/1/thumbnail.jpg",
                            Price = 549,
                            Title = "iPhone 9"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Apple",
                            Category = "smartphones",
                            Image = "https://i.dummyjson.com/data/products/2/thumbnail.jpg",
                            Price = 899,
                            Title = "iPhone X"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Samsung",
                            Category = "smartphones",
                            Image = "https://i.dummyjson.com/data/products/3/thumbnail.jpg",
                            Price = 1249,
                            Title = "Samsung Universe 9"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "OPPO",
                            Category = "smartphones",
                            Image = "https://i.dummyjson.com/data/products/4/thumbnail.jpg",
                            Price = 280,
                            Title = "OPPOF19"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Huawei",
                            Category = "smartphones",
                            Image = "https://i.dummyjson.com/data/products/5/thumbnail.jpg",
                            Price = 499,
                            Title = "Huawei P30"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Apple",
                            Category = "laptops",
                            Image = "https://i.dummyjson.com/data/products/6/thumbnail.png",
                            Price = 1749,
                            Title = "MacBook Pro"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Samsung",
                            Category = "laptops",
                            Image = "https://i.dummyjson.com/data/products/7/thumbnail.jpg",
                            Price = 1499,
                            Title = "Samsung Galaxy Book"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Microsoft Surface",
                            Category = "laptops",
                            Image = "https://i.dummyjson.com/data/products/8/thumbnail.jpg",
                            Price = 1499,
                            Title = "Microsoft Surface Laptop 4"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Infinix",
                            Category = "laptops",
                            Image = "https://i.dummyjson.com/data/products/9/thumbnail.jpg",
                            Price = 1099,
                            Title = "Infinix INBOOK"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "HP Pavilion",
                            Category = "laptops",
                            Image = "https://i.dummyjson.com/data/products/10/thumbnail.jpeg",
                            Price = 1099,
                            Title = "HP Pavilion 15-DK1056WM"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "Impression of Acqua Di Gio",
                            Category = "fragrances",
                            Image = "https://i.dummyjson.com/data/products/11/thumbnail.jpg",
                            Price = 13,
                            Title = "perfume Oil"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "Royal_Mirage",
                            Category = "fragrances",
                            Image = "https://i.dummyjson.com/data/products/12/thumbnail.jpg",
                            Price = 40,
                            Title = "Brown Perfume"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "Fog Scent Xpressio",
                            Category = "fragrances",
                            Image = "https://i.dummyjson.com/data/products/13/thumbnail.webp",
                            Price = 13,
                            Title = "Fog Scent Xpressio Perfume"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Al Munakh",
                            Category = "fragrances",
                            Image = "https://i.dummyjson.com/data/products/14/thumbnail.jpg",
                            Price = 120,
                            Title = "Non-Alcoholic Concentrated Perfume Oil"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "Lord - Al-Rehab",
                            Category = "fragrances",
                            Image = "https://i.dummyjson.com/data/products/15/thumbnail.jpg",
                            Price = 30,
                            Title = "Eau De Perfume Spray"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "L'Oreal Paris",
                            Category = "skincare",
                            Image = "https://i.dummyjson.com/data/products/16/thumbnail.jpg",
                            Price = 19,
                            Title = "Hyaluronic Acid Serum"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "Hemani Tea",
                            Category = "skincare",
                            Image = "https://i.dummyjson.com/data/products/17/thumbnail.jpg",
                            Price = 12,
                            Title = "Tree Oil 30ml"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "Dermive",
                            Category = "skincare",
                            Image = "https://i.dummyjson.com/data/products/18/thumbnail.jpg",
                            Price = 40,
                            Title = "Oil Free Moisturizer 100ml"
                        },
                        new
                        {
                            Id = 19,
                            Brand = "ROREC White Rice",
                            Category = "skincare",
                            Image = "https://i.dummyjson.com/data/products/19/thumbnail.jpg",
                            Price = 46,
                            Title = "Skin Beauty Serum."
                        },
                        new
                        {
                            Id = 20,
                            Brand = "Fair & Clear",
                            Category = "skincare",
                            Image = "https://i.dummyjson.com/data/products/20/thumbnail.jpg",
                            Price = 70,
                            Title = "Freckle Treatment Cream- 15gm"
                        },
                        new
                        {
                            Id = 21,
                            Brand = "Saaf & Khaas",
                            Category = "groceries",
                            Image = "https://i.dummyjson.com/data/products/21/thumbnail.png",
                            Price = 20,
                            Title = "- Daal Masoor 500 grams"
                        },
                        new
                        {
                            Id = 22,
                            Brand = "Bake Parlor Big",
                            Category = "groceries",
                            Image = "https://i.dummyjson.com/data/products/22/thumbnail.jpg",
                            Price = 14,
                            Title = "Elbow Macaroni - 400 gm"
                        },
                        new
                        {
                            Id = 23,
                            Brand = "Baking Food Items",
                            Category = "groceries",
                            Image = "https://i.dummyjson.com/data/products/23/thumbnail.jpg",
                            Price = 14,
                            Title = "Orange Essence Food Flavou"
                        },
                        new
                        {
                            Id = 24,
                            Brand = "fauji",
                            Category = "groceries",
                            Image = "https://i.dummyjson.com/data/products/24/thumbnail.jpg",
                            Price = 46,
                            Title = "cereals muesli fruit nuts"
                        },
                        new
                        {
                            Id = 25,
                            Brand = "Dry Rose",
                            Category = "groceries",
                            Image = "https://i.dummyjson.com/data/products/25/thumbnail.jpg",
                            Price = 70,
                            Title = "Gulab Powder 50 Gram"
                        },
                        new
                        {
                            Id = 26,
                            Brand = "Boho Decor",
                            Category = "home-decoration",
                            Image = "https://i.dummyjson.com/data/products/26/thumbnail.jpg",
                            Price = 41,
                            Title = "Plant Hanger For Home"
                        },
                        new
                        {
                            Id = 27,
                            Brand = "Flying Wooden",
                            Category = "home-decoration",
                            Image = "https://i.dummyjson.com/data/products/27/thumbnail.webp",
                            Price = 51,
                            Title = "Flying Wooden Bird"
                        },
                        new
                        {
                            Id = 28,
                            Brand = "LED Lights",
                            Category = "home-decoration",
                            Image = "https://i.dummyjson.com/data/products/28/thumbnail.jpg",
                            Price = 20,
                            Title = "3D Embellishment Art Lamp"
                        },
                        new
                        {
                            Id = 29,
                            Brand = "luxury palace",
                            Category = "home-decoration",
                            Image = "https://i.dummyjson.com/data/products/29/thumbnail.webp",
                            Price = 60,
                            Title = "Handcraft Chinese style"
                        },
                        new
                        {
                            Id = 30,
                            Brand = "Golden",
                            Category = "home-decoration",
                            Image = "https://i.dummyjson.com/data/products/30/thumbnail.jpg",
                            Price = 30,
                            Title = "Key Holder"
                        });
                });

            modelBuilder.Entity("API.Models.User", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
