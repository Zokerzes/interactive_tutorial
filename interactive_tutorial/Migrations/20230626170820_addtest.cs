using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace interactive_tutorial.Migrations
{
    /// <inheritdoc />
    public partial class addtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "answersTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answers = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answersTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "questionsTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_questionsTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TrueAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrueAnswersNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrueAnswers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionsTextsId = table.Column<int>(type: "int", nullable: false),
                    AnswersId = table.Column<int>(type: "int", nullable: false),
                    TrueAnswersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_TrueAnswers_TrueAnswersId",
                        column: x => x.TrueAnswersId,
                        principalTable: "TrueAnswers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tests_answersTexts_AnswersId",
                        column: x => x.AnswersId,
                        principalTable: "answersTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tests_questionsTexts_QuestionsTextsId",
                        column: x => x.QuestionsTextsId,
                        principalTable: "questionsTexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_AnswersId",
                table: "Tests",
                column: "AnswersId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_QuestionsTextsId",
                table: "Tests",
                column: "QuestionsTextsId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_TrueAnswersId",
                table: "Tests",
                column: "TrueAnswersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "TrueAnswers");

            migrationBuilder.DropTable(
                name: "answersTexts");

            migrationBuilder.DropTable(
                name: "questionsTexts");
        }
    }
}
