using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassLibrary1.Migrations
{
    public partial class aralik_24_11_42 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbNameOnThisDbServer_DbServerParameters_B_03_DbServerParametersId",
                table: "DbNameOnThisDbServer");

            migrationBuilder.DropForeignKey(
                name: "FK_FilesToBeBackup_UserJobs_B_02_UserJobsId",
                table: "FilesToBeBackup");

            migrationBuilder.DropForeignKey(
                name: "FK_FoldersToBeBackup_UserJobs_B_02_UserJobsId",
                table: "FoldersToBeBackup");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_UserJobs_B_02_UserJobsId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_User_B_01_UserId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_DbServerParameters_DbServerParametersId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_Destination_Cloud_destination_CloudId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_Destination_Local_destination_LocalId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_Destination_Network_destination_NetworkId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_NotificationEmail_notificationEmailId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_Schedule_scheduleId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_B_01_UserId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_DbServerParametersId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_destination_CloudId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_destination_LocalId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_destination_NetworkId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_notificationEmailId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_scheduleId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_B_02_UserJobsId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_FoldersToBeBackup_B_02_UserJobsId",
                table: "FoldersToBeBackup");

            migrationBuilder.DropIndex(
                name: "IX_FilesToBeBackup_B_02_UserJobsId",
                table: "FilesToBeBackup");

            migrationBuilder.DropIndex(
                name: "IX_DbNameOnThisDbServer_B_03_DbServerParametersId",
                table: "DbNameOnThisDbServer");

            migrationBuilder.DropColumn(
                name: "B_01_UserId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "DbServerParametersId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "JobName",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "destination_CloudId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "destination_LocalId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "destination_NetworkId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "notificationEmailId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "scheduleId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "B_02_UserJobsId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "B_02_UserJobsId",
                table: "FoldersToBeBackup");

            migrationBuilder.DropColumn(
                name: "B_02_UserJobsId",
                table: "FilesToBeBackup");

            migrationBuilder.DropColumn(
                name: "B_03_DbServerParametersId",
                table: "DbNameOnThisDbServer");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "UserJobs",
                newName: "isActive");

            migrationBuilder.AlterColumn<bool>(
                name: "isActive",
                table: "UserJobs",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "UserSqlBackupId",
                table: "UserJobs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "createdTime",
                table: "UserJobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "UserJobs",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "updatedTime",
                table: "UserJobs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "Schedule",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "NotificationEmail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "Logs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "FoldersToBeBackup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "FilesToBeBackup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "Destination_Network",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "Destination_Local",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "Destination_Cloud",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserJobsId",
                table: "DbServerParameters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DbServerParametersId",
                table: "DbNameOnThisDbServer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserJobs_UserSqlBackupId",
                table: "UserJobs",
                column: "UserSqlBackupId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_UserJobsId",
                table: "Schedule",
                column: "UserJobsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotificationEmail_UserJobsId",
                table: "NotificationEmail",
                column: "UserJobsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UserJobsId",
                table: "Logs",
                column: "UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_FoldersToBeBackup_UserJobsId",
                table: "FoldersToBeBackup",
                column: "UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_FilesToBeBackup_UserJobsId",
                table: "FilesToBeBackup",
                column: "UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_Network_UserJobsId",
                table: "Destination_Network",
                column: "UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_Local_UserJobsId",
                table: "Destination_Local",
                column: "UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_Destination_Cloud_UserJobsId",
                table: "Destination_Cloud",
                column: "UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_DbServerParameters_UserJobsId",
                table: "DbServerParameters",
                column: "UserJobsId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DbNameOnThisDbServer_DbServerParametersId",
                table: "DbNameOnThisDbServer",
                column: "DbServerParametersId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbNameOnThisDbServer_DbServerParameters_DbServerParametersId",
                table: "DbNameOnThisDbServer",
                column: "DbServerParametersId",
                principalTable: "DbServerParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DbServerParameters_UserJobs_UserJobsId",
                table: "DbServerParameters",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Cloud_UserJobs_UserJobsId",
                table: "Destination_Cloud",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Local_UserJobs_UserJobsId",
                table: "Destination_Local",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Destination_Network_UserJobs_UserJobsId",
                table: "Destination_Network",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilesToBeBackup_UserJobs_UserJobsId",
                table: "FilesToBeBackup",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FoldersToBeBackup_UserJobs_UserJobsId",
                table: "FoldersToBeBackup",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_UserJobs_UserJobsId",
                table: "Logs",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationEmail_UserJobs_UserJobsId",
                table: "NotificationEmail",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_UserJobs_UserJobsId",
                table: "Schedule",
                column: "UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_User_UserSqlBackupId",
                table: "UserJobs",
                column: "UserSqlBackupId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DbNameOnThisDbServer_DbServerParameters_DbServerParametersId",
                table: "DbNameOnThisDbServer");

            migrationBuilder.DropForeignKey(
                name: "FK_DbServerParameters_UserJobs_UserJobsId",
                table: "DbServerParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Cloud_UserJobs_UserJobsId",
                table: "Destination_Cloud");

            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Local_UserJobs_UserJobsId",
                table: "Destination_Local");

            migrationBuilder.DropForeignKey(
                name: "FK_Destination_Network_UserJobs_UserJobsId",
                table: "Destination_Network");

            migrationBuilder.DropForeignKey(
                name: "FK_FilesToBeBackup_UserJobs_UserJobsId",
                table: "FilesToBeBackup");

            migrationBuilder.DropForeignKey(
                name: "FK_FoldersToBeBackup_UserJobs_UserJobsId",
                table: "FoldersToBeBackup");

            migrationBuilder.DropForeignKey(
                name: "FK_Logs_UserJobs_UserJobsId",
                table: "Logs");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationEmail_UserJobs_UserJobsId",
                table: "NotificationEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_UserJobs_UserJobsId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_User_UserSqlBackupId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_UserJobs_UserSqlBackupId",
                table: "UserJobs");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_UserJobsId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_NotificationEmail_UserJobsId",
                table: "NotificationEmail");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UserJobsId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_FoldersToBeBackup_UserJobsId",
                table: "FoldersToBeBackup");

            migrationBuilder.DropIndex(
                name: "IX_FilesToBeBackup_UserJobsId",
                table: "FilesToBeBackup");

            migrationBuilder.DropIndex(
                name: "IX_Destination_Network_UserJobsId",
                table: "Destination_Network");

            migrationBuilder.DropIndex(
                name: "IX_Destination_Local_UserJobsId",
                table: "Destination_Local");

            migrationBuilder.DropIndex(
                name: "IX_Destination_Cloud_UserJobsId",
                table: "Destination_Cloud");

            migrationBuilder.DropIndex(
                name: "IX_DbServerParameters_UserJobsId",
                table: "DbServerParameters");

            migrationBuilder.DropIndex(
                name: "IX_DbNameOnThisDbServer_DbServerParametersId",
                table: "DbNameOnThisDbServer");

            migrationBuilder.DropColumn(
                name: "UserSqlBackupId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "createdTime",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "name",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "updatedTime",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "NotificationEmail");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "FoldersToBeBackup");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "FilesToBeBackup");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "Destination_Network");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "Destination_Local");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "Destination_Cloud");

            migrationBuilder.DropColumn(
                name: "UserJobsId",
                table: "DbServerParameters");

            migrationBuilder.DropColumn(
                name: "DbServerParametersId",
                table: "DbNameOnThisDbServer");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "UserJobs",
                newName: "IsActive");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "UserJobs",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "B_01_UserId",
                table: "UserJobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "UserJobs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DbServerParametersId",
                table: "UserJobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "JobName",
                table: "UserJobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "destination_CloudId",
                table: "UserJobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "destination_LocalId",
                table: "UserJobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "destination_NetworkId",
                table: "UserJobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "notificationEmailId",
                table: "UserJobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "scheduleId",
                table: "UserJobs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "B_02_UserJobsId",
                table: "Logs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "B_02_UserJobsId",
                table: "FoldersToBeBackup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "B_02_UserJobsId",
                table: "FilesToBeBackup",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "B_03_DbServerParametersId",
                table: "DbNameOnThisDbServer",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Logs_B_02_UserJobsId",
                table: "Logs",
                column: "B_02_UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_FoldersToBeBackup_B_02_UserJobsId",
                table: "FoldersToBeBackup",
                column: "B_02_UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_FilesToBeBackup_B_02_UserJobsId",
                table: "FilesToBeBackup",
                column: "B_02_UserJobsId");

            migrationBuilder.CreateIndex(
                name: "IX_DbNameOnThisDbServer_B_03_DbServerParametersId",
                table: "DbNameOnThisDbServer",
                column: "B_03_DbServerParametersId");

            migrationBuilder.AddForeignKey(
                name: "FK_DbNameOnThisDbServer_DbServerParameters_B_03_DbServerParametersId",
                table: "DbNameOnThisDbServer",
                column: "B_03_DbServerParametersId",
                principalTable: "DbServerParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FilesToBeBackup_UserJobs_B_02_UserJobsId",
                table: "FilesToBeBackup",
                column: "B_02_UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoldersToBeBackup_UserJobs_B_02_UserJobsId",
                table: "FoldersToBeBackup",
                column: "B_02_UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_UserJobs_B_02_UserJobsId",
                table: "Logs",
                column: "B_02_UserJobsId",
                principalTable: "UserJobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_User_B_01_UserId",
                table: "UserJobs",
                column: "B_01_UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_DbServerParameters_DbServerParametersId",
                table: "UserJobs",
                column: "DbServerParametersId",
                principalTable: "DbServerParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_Destination_Cloud_destination_CloudId",
                table: "UserJobs",
                column: "destination_CloudId",
                principalTable: "Destination_Cloud",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_Destination_Local_destination_LocalId",
                table: "UserJobs",
                column: "destination_LocalId",
                principalTable: "Destination_Local",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_Destination_Network_destination_NetworkId",
                table: "UserJobs",
                column: "destination_NetworkId",
                principalTable: "Destination_Network",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_NotificationEmail_notificationEmailId",
                table: "UserJobs",
                column: "notificationEmailId",
                principalTable: "NotificationEmail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_Schedule_scheduleId",
                table: "UserJobs",
                column: "scheduleId",
                principalTable: "Schedule",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
