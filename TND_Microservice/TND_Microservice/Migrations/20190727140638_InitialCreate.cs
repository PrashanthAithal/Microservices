using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TND_Microservice.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    FeedbackDate = table.Column<string>(nullable: true),
                    EmployeeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TrainingName = table.Column<string>(nullable: true),
                    TrainingDate = table.Column<string>(nullable: true),
                    TrainerName = table.Column<string>(nullable: true),
                    FeedbackID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "ID", "Description", "EmployeeName", "FeedbackDate" },
                values: new object[] { 1001, "Microservice Training was very informative.", "employee_1", "27 July 2019" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "ID", "Description", "EmployeeName", "FeedbackDate" },
                values: new object[] { 1002, "Microservice Training was very informative.", "employee_1", "27 July 2019" });

            migrationBuilder.InsertData(
                table: "Feedbacks",
                columns: new[] { "ID", "Description", "EmployeeName", "FeedbackDate" },
                values: new object[] { 1003, "Microservice Training was very informative.", "employee_1", "27 July 2019" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Trainings");
        }
    }
}
