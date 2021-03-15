using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpecialTransport.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Roles",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        AccessName = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Roles", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Statuses",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Statuses", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TransportTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TransportTypes", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserTypes",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserTypes", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_UserTypes_Roles_RoleId",
            //            column: x => x.RoleId,
            //            principalTable: "Roles",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Transports",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        StateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TransportTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Transports", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Transports_TransportTypes_TransportTypeId",
            //            column: x => x.TransportTypeId,
            //            principalTable: "TransportTypes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        UserTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Users_UserTypes_UserTypeId",
            //            column: x => x.UserTypeId,
            //            principalTable: "UserTypes",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Orders",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Coordinates = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        TransportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        cost = table.Column<double>(type: "float", nullable: false),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        customerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
            //        Mark = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Discription = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Orders", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Orders_Statuses_StatusId",
            //            column: x => x.StatusId,
            //            principalTable: "Statuses",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Orders_Transports_TransportId",
            //            column: x => x.TransportId,
            //            principalTable: "Transports",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Orders_Users_customerId",
            //            column: x => x.customerId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Orders_customerId",
            //    table: "Orders",
            //    column: "customerId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Orders_StatusId",
            //    table: "Orders",
            //    column: "StatusId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Orders_TransportId",
            //    table: "Orders",
            //    column: "TransportId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Transports_TransportTypeId",
            //    table: "Transports",
            //    column: "TransportTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Users_UserTypeId",
            //    table: "Users",
            //    column: "UserTypeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserTypes_RoleId",
            //    table: "UserTypes",
            //    column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Transports");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "TransportTypes");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
