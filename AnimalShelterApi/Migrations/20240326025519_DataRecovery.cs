using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class DataRecovery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7,
                column: "Sex",
                value: "Female");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 7,
                column: "Sex",
                value: null);
        }
    }
}
