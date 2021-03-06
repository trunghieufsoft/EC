﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class Database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_COUNTRY",
                columns: table => new
                {
                    CNY_CD = table.Column<string>(maxLength: 128, nullable: false),
                    REGION = table.Column<string>(maxLength: 2048, nullable: true),
                    CNY_NA = table.Column<string>(maxLength: 2048, nullable: false),
                    CCY_SIG = table.Column<string>(maxLength: 128, nullable: false),
                    CCY_NA = table.Column<string>(maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_COUNTRY", x => x.CNY_CD);
                });

            migrationBuilder.CreateTable(
                name: "TBL_GROUP",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATED_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    CREATED_DT = table.Column<DateTime>(nullable: true),
                    LAST_UDT_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    LAST_UDT_DT = table.Column<DateTime>(nullable: true),
                    GROUP_CD = table.Column<string>(maxLength: 128, nullable: true),
                    GROUP_NA = table.Column<string>(maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_GROUP", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_LOG_WORK",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    Exception = table.Column<string>(nullable: true),
                    LogEvent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_LOG_WORK", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBL_PACKAGE",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATED_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    CREATED_DT = table.Column<DateTime>(nullable: true),
                    LAST_UDT_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    LAST_UDT_DT = table.Column<DateTime>(nullable: true),
                    PACKAGE_NO = table.Column<string>(maxLength: 128, nullable: true),
                    SENDER_ADD = table.Column<string>(maxLength: 2048, nullable: false),
                    SENDER_TM = table.Column<DateTime>(nullable: true),
                    STATUS = table.Column<string>(maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_PACKAGE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_SYS_CONFIG",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATED_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    CREATED_DT = table.Column<DateTime>(nullable: true),
                    LAST_UDT_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    LAST_UDT_DT = table.Column<DateTime>(nullable: true),
                    KEY = table.Column<string>(maxLength: 2048, nullable: true),
                    VALUE = table.Column<string>(maxLength: 2048, nullable: true),
                    VALUE_UNIT = table.Column<string>(maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SYS_CONFIG", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_USER",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATED_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    CREATED_DT = table.Column<DateTime>(nullable: true),
                    LAST_UDT_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    LAST_UDT_DT = table.Column<DateTime>(nullable: true),
                    LOGIN_FAILED_NR = table.Column<int>(nullable: true),
                    TOKEN = table.Column<string>(maxLength: 2048, nullable: true),
                    SUBCRISE_TOKEN = table.Column<string>(maxLength: 2048, nullable: true),
                    TOKEN_EXPIRED_DT = table.Column<DateTime>(nullable: true),
                    LOGIN_TM = table.Column<DateTime>(nullable: true),
                    PASSWORD = table.Column<string>(maxLength: 1024, nullable: false),
                    PASSWORD_LAST_UDT = table.Column<DateTime>(nullable: true),
                    USERNAME = table.Column<string>(maxLength: 2048, nullable: false),
                    CNY_CD = table.Column<string>(maxLength: 128, nullable: true),
                    CODE = table.Column<string>(maxLength: 128, nullable: false),
                    FULL_NAME = table.Column<string>(maxLength: 2048, nullable: false),
                    USER_TYP = table.Column<string>(maxLength: 2048, nullable: false),
                    GROUP_UND_SF = table.Column<string>(maxLength: 4096, nullable: true),
                    USERS_UND_MN = table.Column<string>(maxLength: 4096, nullable: true),
                    STATUS = table.Column<string>(maxLength: 2048, nullable: false),
                    END_OF_DAY = table.Column<bool>(nullable: false),
                    ADDRESS = table.Column<string>(maxLength: 2048, nullable: false),
                    EMAIL = table.Column<string>(maxLength: 2048, nullable: true),
                    PHONE = table.Column<string>(maxLength: 128, nullable: false),
                    START_DT = table.Column<DateTime>(nullable: true),
                    EXPIRED_DT = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_USER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_USER_TBL_COUNTRY_CNY_CD",
                        column: x => x.CNY_CD,
                        principalTable: "TBL_COUNTRY",
                        principalColumn: "CNY_CD",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TBL_TRANSPORT",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATED_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    CREATED_DT = table.Column<DateTime>(nullable: true),
                    LAST_UDT_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    LAST_UDT_DT = table.Column<DateTime>(nullable: true),
                    DRIVER_CD = table.Column<Guid>(nullable: false),
                    PACKAGE_NO = table.Column<Guid>(nullable: false),
                    TRANS_TYP = table.Column<string>(maxLength: 2048, nullable: false),
                    RECIPIENT_ADD = table.Column<string>(maxLength: 2048, nullable: false),
                    CONTENT = table.Column<string>(maxLength: 2048, nullable: true),
                    PICKUP_TM = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TRANSPORT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_TRANSPORT_TBL_USER_DRIVER_CD",
                        column: x => x.DRIVER_CD,
                        principalTable: "TBL_USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBL_TRANSPORT_TBL_PACKAGE_PACKAGE_NO",
                        column: x => x.PACKAGE_NO,
                        principalTable: "TBL_PACKAGE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBL_SUB_PACKAGE",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CREATED_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    CREATED_DT = table.Column<DateTime>(nullable: true),
                    LAST_UDT_USER = table.Column<string>(maxLength: 2048, nullable: true),
                    LAST_UDT_DT = table.Column<DateTime>(nullable: true),
                    SUB_PACKAGE_NO = table.Column<string>(maxLength: 128, nullable: true),
                    TRANS_CD = table.Column<Guid>(nullable: false),
                    PRODUCT_NA = table.Column<string>(maxLength: 2048, nullable: false),
                    QUANTITY = table.Column<int>(nullable: false),
                    PRICE = table.Column<string>(maxLength: 1024, nullable: false),
                    DELIVERY_ADD = table.Column<string>(maxLength: 4096, nullable: false),
                    DELIVERY_TM = table.Column<DateTime>(nullable: true),
                    STATUS = table.Column<string>(maxLength: 2048, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_SUB_PACKAGE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TBL_SUB_PACKAGE_TBL_TRANSPORT_TRANS_CD",
                        column: x => x.TRANS_CD,
                        principalTable: "TBL_TRANSPORT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_SUB_PACKAGE_TRANS_CD",
                table: "TBL_SUB_PACKAGE",
                column: "TRANS_CD");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TRANSPORT_DRIVER_CD",
                table: "TBL_TRANSPORT",
                column: "DRIVER_CD");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_TRANSPORT_PACKAGE_NO",
                table: "TBL_TRANSPORT",
                column: "PACKAGE_NO");

            migrationBuilder.CreateIndex(
                name: "IX_TBL_USER_CNY_CD",
                table: "TBL_USER",
                column: "CNY_CD");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_GROUP");

            migrationBuilder.DropTable(
                name: "TBL_LOG_WORK");

            migrationBuilder.DropTable(
                name: "TBL_SUB_PACKAGE");

            migrationBuilder.DropTable(
                name: "TBL_SYS_CONFIG");

            migrationBuilder.DropTable(
                name: "TBL_TRANSPORT");

            migrationBuilder.DropTable(
                name: "TBL_USER");

            migrationBuilder.DropTable(
                name: "TBL_PACKAGE");

            migrationBuilder.DropTable(
                name: "TBL_COUNTRY");
        }
    }
}
