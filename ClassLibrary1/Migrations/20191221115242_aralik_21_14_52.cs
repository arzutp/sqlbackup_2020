using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class aralik_21_14_52 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DbServerParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerName = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    AuthType = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbServerParameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destination_Cloud",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CloudPath = table.Column<string>(nullable: true),
                    CloudAccountname = table.Column<string>(nullable: true),
                    CloudAccountPass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination_Cloud", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destination_Local",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalPath = table.Column<string>(nullable: true),
                    LocalAccountName = table.Column<string>(nullable: true),
                    LocalAccountPass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination_Local", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destination_Network",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NetworkPath = table.Column<string>(nullable: true),
                    NetworkAccount = table.Column<string>(nullable: true),
                    NetworkPass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination_Network", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotificationEmail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromName = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    SMTPServer = table.Column<string>(nullable: true),
                    SMTPUserName = table.Column<string>(nullable: true),
                    SMTPUserPass = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationEmail", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BackupType = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Freq = table.Column<byte>(nullable: false),
                    IsSunday = table.Column<bool>(nullable: false),
                    IsMonday = table.Column<bool>(nullable: false),
                    IsTuesday = table.Column<bool>(nullable: false),
                    IsWednesday = table.Column<bool>(nullable: false),
                    IsThursday = table.Column<bool>(nullable: false),
                    IsFriday = table.Column<bool>(nullable: false),
                    IsSaturday = table.Column<bool>(nullable: false),
                    StartRunBetween = table.Column<DateTime>(nullable: true),
                    EndRunBetween = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    AccountName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DbNameOnThisDbServer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsSelected = table.Column<bool>(nullable: false),
                    B_03_DbServerParametersId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbNameOnThisDbServer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbNameOnThisDbServer_DbServerParameters_B_03_DbServerParametersId",
                        column: x => x.B_03_DbServerParametersId,
                        principalTable: "DbServerParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserJobs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DbServerParametersId = table.Column<int>(nullable: true),
                    destination_LocalId = table.Column<int>(nullable: true),
                    destination_NetworkId = table.Column<int>(nullable: true),
                    destination_CloudId = table.Column<int>(nullable: true),
                    notificationEmailId = table.Column<int>(nullable: true),
                    scheduleId = table.Column<int>(nullable: true),
                    B_01_UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserJobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserJobs_User_B_01_UserId",
                        column: x => x.B_01_UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_DbServerParameters_DbServerParametersId",
                        column: x => x.DbServerParametersId,
                        principalTable: "DbServerParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_Destination_Cloud_destination_CloudId",
                        column: x => x.destination_CloudId,
                        principalTable: "Destination_Cloud",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_Destination_Local_destination_LocalId",
                        column: x => x.destination_LocalId,
                        principalTable: "Destination_Local",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_Destination_Network_destination_NetworkId",
                        column: x => x.destination_NetworkId,
                        principalTable: "Destination_Network",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_NotificationEmail_notificationEmailId",
                        column: x => x.notificationEmailId,
                        principalTable: "NotificationEmail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserJobs_Schedule_scheduleId",
                        column: x => x.scheduleId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FilesToBeBackup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fileName = table.Column<string>(nullable: true),
                    B_02_UserJobsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilesToBeBackup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FilesToBeBackup_UserJobs_B_02_UserJobsId",
                        column: x => x.B_02_UserJobsId,
                        principalTable: "UserJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoldersToBeBackup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    folderName = table.Column<string>(nullable: true),
                    B_02_UserJobsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoldersToBeBackup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoldersToBeBackup_UserJobs_B_02_UserJobsId",
                        column: x => x.B_02_UserJobsId,
                        principalTable: "UserJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<string>(nullable: true),
                    FileSize = table.Column<string>(nullable: true),
                    StatusDetail = table.Column<string>(nullable: true),
                    B_02_UserJobsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_UserJobs_B_02_UserJobsId",
                        column: x => x.B_02_UserJobsId,
                        principalTable: "UserJobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DbNameOnThisDbServer_B_03_DbServerParametersId",
                table: "DbNameOnThisDbServer",
                column: "B_03_DbServerParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_FilesToBeBackup_B_02_UserJobsId",
                table: "FilesToBeBackup",
                column: "B_02_UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_FoldersToBeBackup_B_02_UserJobsId",
                table: "FoldersToBeBackup",
                column: "B_02_UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_B_02_UserJobsId",
                table: "Logs",
                column: "B_02_UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_B_01_UserId",
                table: "UserJobs",
                column: "B_01_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_DbServerParametersId",
                table: "UserJobs",
                column: "DbServerParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_destination_CloudId",
                table: "UserJobs",
                column: "destination_CloudId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_destination_LocalId",
                table: "UserJobs",
                column: "destination_LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_destination_NetworkId",
                table: "UserJobs",
                column: "destination_NetworkId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_notificationEmailId",
                table: "UserJobs",
                column: "notificationEmailId");

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_scheduleId",
                table: "UserJobs",
                column: "scheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DbNameOnThisDbServer");

            migrationBuilder.DropTable(
                name: "FilesToBeBackup");

            migrationBuilder.DropTable(
                name: "FoldersToBeBackup");

            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "UserJobs");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DbServerParameters");

            migrationBuilder.DropTable(
                name: "Destination_Cloud");

            migrationBuilder.DropTable(
                name: "Destination_Local");

            migrationBuilder.DropTable(
                name: "Destination_Network");

            migrationBuilder.DropTable(
                name: "NotificationEmail");

            migrationBuilder.DropTable(
                name: "Schedule");
        }
    }
}
