using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Outstaff.Migrations
{
    /// <inheritdoc />
    public partial class InitSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Contractors_ContractorId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_Contracts_ContractId",
                table: "Rate");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplementaryAgreement_Contracts_ContractId",
                table: "SupplementaryAgreement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contracts",
                table: "Contracts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contractors",
                table: "Contractors");

            migrationBuilder.RenameTable(
                name: "Contracts",
                newName: "Contract");

            migrationBuilder.RenameTable(
                name: "Contractors",
                newName: "Contractor");

            migrationBuilder.RenameIndex(
                name: "IX_Contracts_ContractorId",
                table: "Contract",
                newName: "IX_Contract_ContractorId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contractor",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Contractor",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contract",
                table: "Contract",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contractor",
                table: "Contractor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Contractor_ContractorId",
                table: "Contract",
                column: "ContractorId",
                principalTable: "Contractor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_Contract_ContractId",
                table: "Rate",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplementaryAgreement_Contract_ContractId",
                table: "SupplementaryAgreement",
                column: "ContractId",
                principalTable: "Contract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Contractor_ContractorId",
                table: "Contract");

            migrationBuilder.DropForeignKey(
                name: "FK_Rate_Contract_ContractId",
                table: "Rate");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplementaryAgreement_Contract_ContractId",
                table: "SupplementaryAgreement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contractor",
                table: "Contractor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contract",
                table: "Contract");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contractor");

            migrationBuilder.RenameTable(
                name: "Contractor",
                newName: "Contractors");

            migrationBuilder.RenameTable(
                name: "Contract",
                newName: "Contracts");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Contractors",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_ContractorId",
                table: "Contracts",
                newName: "IX_Contracts_ContractorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contractors",
                table: "Contractors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contracts",
                table: "Contracts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Contractors_ContractorId",
                table: "Contracts",
                column: "ContractorId",
                principalTable: "Contractors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rate_Contracts_ContractId",
                table: "Rate",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplementaryAgreement_Contracts_ContractId",
                table: "SupplementaryAgreement",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
