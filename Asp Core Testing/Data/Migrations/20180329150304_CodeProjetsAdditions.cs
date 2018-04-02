using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Asp_Core_Testing.Data.Migrations
{
    public partial class CodeProjetsAdditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileUrl",
                table: "CodeProjects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CodeProjects",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileUrl",
                table: "CodeProjects");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CodeProjects");
        }
    }
}
