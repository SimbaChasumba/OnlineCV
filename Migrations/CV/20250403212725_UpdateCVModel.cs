using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCV.Migrations.CV
{
    /// <inheritdoc />
    public partial class UpdateCVModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_CVs_CVModelId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CVs_CVModelId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalSkills_CVs_CVModelId",
                table: "TechnicalSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_CVs_CVModelId",
                table: "WorkExperiences");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "WorkExperiences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "TechnicalSkills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "Educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "CVs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_CVs_CVModelId",
                table: "Educations",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_CVs_CVModelId",
                table: "Projects",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalSkills_CVs_CVModelId",
                table: "TechnicalSkills",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_CVs_CVModelId",
                table: "WorkExperiences",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_CVs_CVModelId",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CVs_CVModelId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_TechnicalSkills_CVs_CVModelId",
                table: "TechnicalSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkExperiences_CVs_CVModelId",
                table: "WorkExperiences");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "WorkExperiences",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "WorkExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "TechnicalSkills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CVModelId",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "CVs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_CVs_CVModelId",
                table: "Educations",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_CVs_CVModelId",
                table: "Projects",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TechnicalSkills_CVs_CVModelId",
                table: "TechnicalSkills",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkExperiences_CVs_CVModelId",
                table: "WorkExperiences",
                column: "CVModelId",
                principalTable: "CVs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
