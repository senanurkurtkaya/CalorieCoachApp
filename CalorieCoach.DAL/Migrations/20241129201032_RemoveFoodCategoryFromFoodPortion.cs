using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalorieCoach.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveFoodCategoryFromFoodPortion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodPortions_FoodCategories_FoodCategoryId",
                table: "FoodPortions");

            migrationBuilder.AlterColumn<int>(
                name: "FoodCategoryId",
                table: "FoodPortions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPortions_FoodCategories_FoodCategoryId",
                table: "FoodPortions",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodPortions_FoodCategories_FoodCategoryId",
                table: "FoodPortions");

            migrationBuilder.AlterColumn<int>(
                name: "FoodCategoryId",
                table: "FoodPortions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodPortions_FoodCategories_FoodCategoryId",
                table: "FoodPortions",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
