﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TandooriRecipe.Models;

namespace TandooriRecipe.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191201223306_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TandooriRecipe.Models.Ingredients", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ingredient");

                    b.Property<int?>("RecipeModelRecipeId");

                    b.HasKey("RecipeId");

                    b.HasIndex("RecipeModelRecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("TandooriRecipe.Models.RecipeModel", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("Directions");

                    b.Property<string>("Name");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("TandooriRecipe.Models.Reviews", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("RecipeModelRecipeId");

                    b.Property<string>("ReviewDesc");

                    b.HasKey("RecipeId");

                    b.HasIndex("RecipeModelRecipeId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("TandooriRecipe.Models.Ingredients", b =>
                {
                    b.HasOne("TandooriRecipe.Models.RecipeModel")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeModelRecipeId");
                });

            modelBuilder.Entity("TandooriRecipe.Models.Reviews", b =>
                {
                    b.HasOne("TandooriRecipe.Models.RecipeModel")
                        .WithMany("ReviewsDescription")
                        .HasForeignKey("RecipeModelRecipeId");
                });
#pragma warning restore 612, 618
        }
    }
}
