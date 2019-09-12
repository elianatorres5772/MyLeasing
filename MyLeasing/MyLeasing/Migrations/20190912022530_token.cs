﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLeasing.Migrations
{
    public partial class token : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "PropertyImages",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "PropertyImages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
