using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buscandomitrago.Domain.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    IdDrink = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StrDrink = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    StrDrinkAlternate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StrTags = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StrVideo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StrCategory = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StrIBA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StrAlcoholic = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    StrGlass = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StrInstructions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrInstructionsES = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StrInstructionsDE = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrInstructionsFR = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StrInstructionsIT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StrInstructionsZH_HANS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StrInstructionsZH_HANT = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StrDrinkThumb = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StrIngredient1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StrIngredient2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient4 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient5 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient6 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient7 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient8 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient9 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient10 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient11 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient12 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient13 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient14 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrIngredient15 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StrMeasure2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure4 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure5 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure6 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure7 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure8 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure9 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure10 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure11 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure12 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure13 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure14 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrMeasure15 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StrImageSource = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StrImageAttribution = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StrCreativeCommonsConfirmed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.IdDrink);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");
        }
    }
}
