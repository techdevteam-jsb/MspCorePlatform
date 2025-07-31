using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MspCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TPTInheritanceMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_CmdbBaseItems_CmdbConfigurationItemId",
                schema: "public",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_ClientId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_ClientItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_CompanyId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_CompanyItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_ProductItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CmdbBaseItems_Products_ProductId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquiries_CmdbBaseItems_CmdbClientItemId",
                schema: "public",
                table: "Inquiries");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceContracts_CmdbBaseItems_CmdbClientItemId",
                schema: "public",
                table: "ServiceContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceContracts_CmdbBaseItems_CmdbCompanyItemId",
                schema: "public",
                table: "ServiceContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportCases_CmdbBaseItems_CmdbClientItemId",
                schema: "public",
                table: "SupportCases");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportCases_CmdbBaseItems_ConfigurationItemId",
                schema: "public",
                table: "SupportCases");

            migrationBuilder.DropIndex(
                name: "IX_CmdbBaseItems_ClientId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropIndex(
                name: "IX_CmdbBaseItems_ClientItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropIndex(
                name: "IX_CmdbBaseItems_CompanyId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropIndex(
                name: "IX_CmdbBaseItems_CompanyItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropIndex(
                name: "IX_CmdbBaseItems_ProductId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropIndex(
                name: "IX_CmdbBaseItems_ProductItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "AccountManager",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ApplicationName",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "BusinessOwner",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "BusinessStatus",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "BusinessUnit",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "CEOName",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Category",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ClientId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ClientItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ClientName",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ClientStatus",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "CmdbProductItem_ReleaseDate",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "CmdbProductItem_Version",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "CompanyItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ConfigurationId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ContactEmail",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ContactPhone",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "CostCenter",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Country",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Criticality",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Environment",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "EstablishedDate",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "HeadquartersLocation",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "HostingType",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Industry",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "IndustryType",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "InstallDate",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "IsVirtual",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "LastScanDate",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "LicenseType",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "LifecyclePhase",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ManagedBy",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "OperationalStatus",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Platform",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "PrimaryContact",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ProductCode",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ProductItemId",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ProductName",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Region",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "ServiceTier",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Subcategory",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "SupportGroup",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "SupportStatus",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "TechnicalOwner",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "UsageType",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Vendor",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "Version",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "WarrantyPeriod",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.DropColumn(
                name: "WebsiteUrl",
                schema: "public",
                table: "CmdbBaseItems");

            migrationBuilder.CreateTable(
                name: "CmdbConfigurationItems",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ConfigurationId = table.Column<string>(type: "text", nullable: false),
                    Environment = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Subcategory = table.Column<string>(type: "text", nullable: true),
                    Criticality = table.Column<string>(type: "text", nullable: true),
                    OperationalStatus = table.Column<string>(type: "text", nullable: true),
                    InstallDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    LastScanDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ManagedBy = table.Column<string>(type: "text", nullable: true),
                    BusinessUnit = table.Column<string>(type: "text", nullable: true),
                    LifecyclePhase = table.Column<string>(type: "text", nullable: true),
                    SupportGroup = table.Column<string>(type: "text", nullable: true),
                    CostCenter = table.Column<string>(type: "text", nullable: true),
                    UsageType = table.Column<string>(type: "text", nullable: true),
                    IsVirtual = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmdbConfigurationItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmdbConfigurationItems_CmdbBaseItems_Id",
                        column: x => x.Id,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CmdbClientItems",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Industry = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Region = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PrimaryContact = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    AccountManager = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ClientStatus = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmdbClientItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmdbClientItems_CmdbConfigurationItems_Id",
                        column: x => x.Id,
                        principalSchema: "public",
                        principalTable: "CmdbConfigurationItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CmdbCompanyItems",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CompanyName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    RegistrationNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    HeadquartersLocation = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    IndustryType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    WebsiteUrl = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    ContactEmail = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ContactPhone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CEOName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    EstablishedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    BusinessStatus = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmdbCompanyItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmdbCompanyItems_CmdbConfigurationItems_Id",
                        column: x => x.Id,
                        principalSchema: "public",
                        principalTable: "CmdbConfigurationItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CmdbProductItems",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    ProductCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Vendor = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Version = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    WarrantyPeriod = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    LicenseType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmdbProductItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmdbProductItems_CmdbClientItems_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "public",
                        principalTable: "CmdbClientItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbProductItems_CmdbCompanyItems_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "public",
                        principalTable: "CmdbCompanyItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbProductItems_CmdbConfigurationItems_Id",
                        column: x => x.Id,
                        principalSchema: "public",
                        principalTable: "CmdbConfigurationItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CmdbProductItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "public",
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "CmdbApplicationItems",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Version = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Platform = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    BusinessOwner = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    TechnicalOwner = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SupportStatus = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    HostingType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ServiceTier = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ClientItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    CompanyItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductItemId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmdbApplicationItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmdbApplicationItems_CmdbClientItems_ClientItemId",
                        column: x => x.ClientItemId,
                        principalSchema: "public",
                        principalTable: "CmdbClientItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbApplicationItems_CmdbCompanyItems_CompanyItemId",
                        column: x => x.CompanyItemId,
                        principalSchema: "public",
                        principalTable: "CmdbCompanyItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbApplicationItems_CmdbConfigurationItems_Id",
                        column: x => x.Id,
                        principalSchema: "public",
                        principalTable: "CmdbConfigurationItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CmdbApplicationItems_CmdbProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalSchema: "public",
                        principalTable: "CmdbProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CmdbApplicationItems_ClientItemId",
                schema: "public",
                table: "CmdbApplicationItems",
                column: "ClientItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbApplicationItems_CompanyItemId",
                schema: "public",
                table: "CmdbApplicationItems",
                column: "CompanyItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbApplicationItems_ProductItemId",
                schema: "public",
                table: "CmdbApplicationItems",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbProductItems_ClientId",
                schema: "public",
                table: "CmdbProductItems",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbProductItems_CompanyId",
                schema: "public",
                table: "CmdbProductItems",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbProductItems_ProductId",
                schema: "public",
                table: "CmdbProductItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_CmdbConfigurationItems_CmdbConfigurationItemId",
                schema: "public",
                table: "Applications",
                column: "CmdbConfigurationItemId",
                principalSchema: "public",
                principalTable: "CmdbConfigurationItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiries_CmdbClientItems_CmdbClientItemId",
                schema: "public",
                table: "Inquiries",
                column: "CmdbClientItemId",
                principalSchema: "public",
                principalTable: "CmdbClientItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceContracts_CmdbClientItems_CmdbClientItemId",
                schema: "public",
                table: "ServiceContracts",
                column: "CmdbClientItemId",
                principalSchema: "public",
                principalTable: "CmdbClientItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceContracts_CmdbCompanyItems_CmdbCompanyItemId",
                schema: "public",
                table: "ServiceContracts",
                column: "CmdbCompanyItemId",
                principalSchema: "public",
                principalTable: "CmdbCompanyItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupportCases_CmdbClientItems_CmdbClientItemId",
                schema: "public",
                table: "SupportCases",
                column: "CmdbClientItemId",
                principalSchema: "public",
                principalTable: "CmdbClientItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupportCases_CmdbConfigurationItems_ConfigurationItemId",
                schema: "public",
                table: "SupportCases",
                column: "ConfigurationItemId",
                principalSchema: "public",
                principalTable: "CmdbConfigurationItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_CmdbConfigurationItems_CmdbConfigurationItemId",
                schema: "public",
                table: "Applications");

            migrationBuilder.DropForeignKey(
                name: "FK_Inquiries_CmdbClientItems_CmdbClientItemId",
                schema: "public",
                table: "Inquiries");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceContracts_CmdbClientItems_CmdbClientItemId",
                schema: "public",
                table: "ServiceContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceContracts_CmdbCompanyItems_CmdbCompanyItemId",
                schema: "public",
                table: "ServiceContracts");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportCases_CmdbClientItems_CmdbClientItemId",
                schema: "public",
                table: "SupportCases");

            migrationBuilder.DropForeignKey(
                name: "FK_SupportCases_CmdbConfigurationItems_ConfigurationItemId",
                schema: "public",
                table: "SupportCases");

            migrationBuilder.DropTable(
                name: "CmdbApplicationItems",
                schema: "public");

            migrationBuilder.DropTable(
                name: "CmdbProductItems",
                schema: "public");

            migrationBuilder.DropTable(
                name: "CmdbClientItems",
                schema: "public");

            migrationBuilder.DropTable(
                name: "CmdbCompanyItems",
                schema: "public");

            migrationBuilder.DropTable(
                name: "CmdbConfigurationItems",
                schema: "public");

            migrationBuilder.AddColumn<string>(
                name: "AccountManager",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationName",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessOwner",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessStatus",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BusinessUnit",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEOName",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                schema: "public",
                table: "CmdbBaseItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientItemId",
                schema: "public",
                table: "CmdbBaseItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientName",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientStatus",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CmdbProductItem_ReleaseDate",
                schema: "public",
                table: "CmdbBaseItems",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CmdbProductItem_Version",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                schema: "public",
                table: "CmdbBaseItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyItemId",
                schema: "public",
                table: "CmdbBaseItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfigurationId",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactEmail",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ContactPhone",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CostCenter",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Criticality",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Environment",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EstablishedDate",
                schema: "public",
                table: "CmdbBaseItems",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HeadquartersLocation",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HostingType",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Industry",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IndustryType",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InstallDate",
                schema: "public",
                table: "CmdbBaseItems",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "public",
                table: "CmdbBaseItems",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsVirtual",
                schema: "public",
                table: "CmdbBaseItems",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastScanDate",
                schema: "public",
                table: "CmdbBaseItems",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicenseType",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LifecyclePhase",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManagedBy",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationalStatus",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryContact",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductCode",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                schema: "public",
                table: "CmdbBaseItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductItemId",
                schema: "public",
                table: "CmdbBaseItems",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                schema: "public",
                table: "CmdbBaseItems",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ServiceTier",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subcategory",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupportGroup",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupportStatus",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TechnicalOwner",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsageType",
                schema: "public",
                table: "CmdbBaseItems",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(150)",
                maxLength: 150,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Version",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarrantyPeriod",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebsiteUrl",
                schema: "public",
                table: "CmdbBaseItems",
                type: "character varying(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CmdbBaseItems_ClientId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbBaseItems_ClientItemId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ClientItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbBaseItems_CompanyId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbBaseItems_CompanyItemId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "CompanyItemId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbBaseItems_ProductId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CmdbBaseItems_ProductItemId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ProductItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_CmdbBaseItems_CmdbConfigurationItemId",
                schema: "public",
                table: "Applications",
                column: "CmdbConfigurationItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_ClientId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ClientId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_ClientItemId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ClientItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_CompanyId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "CompanyId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_CompanyItemId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "CompanyItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CmdbBaseItems_CmdbBaseItems_ProductItemId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ProductItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_CmdbBaseItems_Products_ProductId",
                schema: "public",
                table: "CmdbBaseItems",
                column: "ProductId",
                principalSchema: "public",
                principalTable: "Products",
                principalColumn: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inquiries_CmdbBaseItems_CmdbClientItemId",
                schema: "public",
                table: "Inquiries",
                column: "CmdbClientItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceContracts_CmdbBaseItems_CmdbClientItemId",
                schema: "public",
                table: "ServiceContracts",
                column: "CmdbClientItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceContracts_CmdbBaseItems_CmdbCompanyItemId",
                schema: "public",
                table: "ServiceContracts",
                column: "CmdbCompanyItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupportCases_CmdbBaseItems_CmdbClientItemId",
                schema: "public",
                table: "SupportCases",
                column: "CmdbClientItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SupportCases_CmdbBaseItems_ConfigurationItemId",
                schema: "public",
                table: "SupportCases",
                column: "ConfigurationItemId",
                principalSchema: "public",
                principalTable: "CmdbBaseItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
