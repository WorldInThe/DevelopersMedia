using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Asp_Core_Testing.Data.Migrations
{
    public partial class Idfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Images",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "CodeProjects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "CodeComments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Code_Snippets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ModelId",
                table: "Album",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "CodeProjects");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "CodeComments");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Code_Snippets");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Album");
        }
    }
}
