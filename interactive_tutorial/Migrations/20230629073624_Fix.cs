using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace interactive_tutorial.Migrations
{
    /// <inheritdoc />
    public partial class Fix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TrueAnswers_TrueAnswersId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_answersTexts_AnswersId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_questionsTexts_QuestionsTextsId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "answersTexts");

            migrationBuilder.DropTable(
                name: "questionsTexts");

            migrationBuilder.RenameColumn(
                name: "TrueAnswersNumber",
                table: "TrueAnswers",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "TrueAnswersId",
                table: "Tests",
                newName: "TrueAnswerId");

            migrationBuilder.RenameColumn(
                name: "QuestionsTextsId",
                table: "Tests",
                newName: "QuestionTextId");

            migrationBuilder.RenameColumn(
                name: "AnswersId",
                table: "Tests",
                newName: "AnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_TrueAnswersId",
                table: "Tests",
                newName: "IX_Tests_TrueAnswerId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_QuestionsTextsId",
                table: "Tests",
                newName: "IX_Tests_QuestionTextId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_AnswersId",
                table: "Tests",
                newName: "IX_Tests_AnswerId");

            migrationBuilder.CreateTable(
                name: "AnswerTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerTexts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTexts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_AnswerTexts_AnswerId",
                table: "Tests",
                column: "AnswerId",
                principalTable: "AnswerTexts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_QuestionTexts_QuestionTextId",
                table: "Tests",
                column: "QuestionTextId",
                principalTable: "QuestionTexts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TrueAnswers_TrueAnswerId",
                table: "Tests",
                column: "TrueAnswerId",
                principalTable: "TrueAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_AnswerTexts_AnswerId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_QuestionTexts_QuestionTextId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TrueAnswers_TrueAnswerId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "AnswerTexts");

            migrationBuilder.DropTable(
                name: "QuestionTexts");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "TrueAnswers",
                newName: "TrueAnswersNumber");

            migrationBuilder.RenameColumn(
                name: "TrueAnswerId",
                table: "Tests",
                newName: "TrueAnswersId");

            migrationBuilder.RenameColumn(
                name: "QuestionTextId",
                table: "Tests",
                newName: "QuestionsTextsId");

            migrationBuilder.RenameColumn(
                name: "AnswerId",
                table: "Tests",
                newName: "AnswersId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_TrueAnswerId",
                table: "Tests",
                newName: "IX_Tests_TrueAnswersId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_QuestionTextId",
                table: "Tests",
                newName: "IX_Tests_QuestionsTextsId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_AnswerId",
                table: "Tests",
                newName: "IX_Tests_AnswersId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TrueAnswers_TrueAnswersId",
                table: "Tests",
                column: "TrueAnswersId",
                principalTable: "TrueAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_answersTexts_AnswersId",
                table: "Tests",
                column: "AnswersId",
                principalTable: "answersTexts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_questionsTexts_QuestionsTextsId",
                table: "Tests",
                column: "QuestionsTextsId",
                principalTable: "questionsTexts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
