using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Buscandomitrago.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Buscandomitrago.Domain.Utils
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Drink> Drinks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drink>(tb =>
            {
                tb.HasKey(col => col.idDrink);
                tb.Property(e => e.idDrink).HasMaxLength(10);
                tb.Property(e => e.strDrink)
          .HasColumnType("varchar(max)");

                tb.Property(e => e.strDrinkAlternate)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strTags)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strVideo).HasMaxLength(10);

            tb.Property(e => e.strCategory)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strIBA)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strAlcoholic)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strGlass)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strInstructions)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strInstructionsES)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strInstructionsDE)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strInstructionsFR)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strInstructionsIT)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strInstructionsZH_HANS)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strInstructionsZH_HANT)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strDrinkThumb)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strIngredient1).HasMaxLength(60);

                tb.Property(e => e.strIngredient2)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient3)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient4)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient5)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient6)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient7)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient8)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient9)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient10)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient11)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient12)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient13)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient14)
                  .HasMaxLength(60);

                tb.Property(e => e.strIngredient15)
                  .HasMaxLength(60);

                tb.Property(e => e.strMeasure1)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure2)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure3)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure4)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure5)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure6)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure7)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure8)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure9)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure10)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure11)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure12)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure13)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure14)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strMeasure15)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strImageSource)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strImageAttribution)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.strCreativeCommonsConfirmed)
                  .HasColumnType("varchar(max)");

                tb.Property(e => e.dateModified)
                  .HasColumnType("varchar(max)");
            });
        }
    }

}
