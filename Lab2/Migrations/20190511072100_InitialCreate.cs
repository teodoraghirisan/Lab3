﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
              //  name: "Movies",
                //columns: table => new
                //{
                  //  Id = table.Column<int>(nullable: false)
                    //    .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    //Title = table.Column<string>(nullable: true),
                    //Description = table.Column<string>(nullable: true),
                    //Genre = table.Column<string>(nullable: true),
                    //DurationInMinutes = table.Column<int>(nullable: false),
                    //YearOfRelease = table.Column<int>(nullable: false),
                    //Director = table.Column<string>(nullable: true),
                    //Rating = table.Column<int>(nullable: false),
                    //Watched = table.Column<string>(nullable: true)
                //},
                //constraints: table =>
                //{
                  //  table.PrimaryKey("PK_Movies", x => x.Id);
                //});
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
