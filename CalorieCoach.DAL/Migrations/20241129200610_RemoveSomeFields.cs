using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieCoach.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSomeFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calories",
                table: "FoodPortions");

            migrationBuilder.DropColumn(
                name: "FoodName",
                table: "FoodPortions");

            migrationBuilder.DropColumn(
                name: "MealId",
                table: "FoodPortions");

            migrationBuilder.DropColumn(
                name: "PortionSize",
                table: "FoodPortions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Calories",
                table: "FoodPortions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "FoodName",
                table: "FoodPortions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MealId",
                table: "FoodPortions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PortionSize",
                table: "FoodPortions",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
