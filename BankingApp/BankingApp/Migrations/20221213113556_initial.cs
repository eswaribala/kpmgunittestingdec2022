using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankingApp.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    AccountNo = table.Column<long>(name: "Account_No", type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(name: "First_Name", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(name: "Last_Name", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MiddleName = table.Column<string>(name: "Middle_Name", type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactNo = table.Column<long>(name: "Contact_No", type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.AccountNo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
