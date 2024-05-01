using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GUN_RANGE_APP_V5.Migrations
{
    /// <inheritdoc />
    public partial class Inventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shooters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Division = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GunInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QualificationsTraining = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalTrainingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalTrainingHours = table.Column<int>(type: "int", nullable: false),
                    IsRetired = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OfficerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuedEquipment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastRangeDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarksAwards = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shooters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shooters");
        }
    }
}
