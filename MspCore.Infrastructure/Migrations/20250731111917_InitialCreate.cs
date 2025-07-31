using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MspCore.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "ClientAccounts",
                schema: "public",
                columns: table => new
                {
                    ClientAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    AccountName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    AccountCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ContactEmail = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientAccounts", x => x.ClientAccountId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "public",
                columns: table => new
                {
                    ProductCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PortalUsers",
                schema: "public",
                columns: table => new
                {
                    PortalUserId = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Role = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClientAccountId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PortalUsers", x => x.PortalUserId);
                    table.ForeignKey(
                        name: "FK_PortalUsers_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalSchema: "public",
                        principalTable: "ClientAccounts",
                        principalColumn: "ClientAccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "public",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    ProductCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    Category = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: true),
                    ProductCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientAccountId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalSchema: "public",
                        principalTable: "ClientAccounts",
                        principalColumn: "ClientAccountId");
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalSchema: "public",
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "CmdbBaseItems",
                schema: "public",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: false),
                    ItemType = table.Column<string>(type: "text", nullable: false),
                    Owner = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Tags = table.Column<string>(type: "text", nullable: true),
                    Source = table.Column<string>(type: "text", nullable: true),
                    ReferenceCode = table.Column<string>(type: "text", nullable: true),
                    Classification = table.Column<string>(type: "text", nullable: true),
                    IsMonitored = table.Column<bool>(type: "boolean", nullable: false),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "character varying(21)", maxLength: 21, nullable: false),
                    ConfigurationId = table.Column<string>(type: "text", nullable: true),
                    Environment = table.Column<string>(type: "text", nullable: true),
                    Category = table.Column<string>(type: "text", nullable: true),
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
                    IsVirtual = table.Column<bool>(type: "boolean", nullable: true),
                    ApplicationName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
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
                    ProductItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Industry = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Region = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PrimaryContact = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    AccountManager = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ClientStatus = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CompanyName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    RegistrationNumber = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    HeadquartersLocation = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    IndustryType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    WebsiteUrl = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    ContactEmail = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ContactPhone = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CEOName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    EstablishedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    BusinessStatus = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    ProductCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Vendor = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: true),
                    CmdbProductItem_Version = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    WarrantyPeriod = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    LicenseType = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CmdbProductItem_ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uuid", nullable: true),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CmdbBaseItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CmdbBaseItems_CmdbBaseItems_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbBaseItems_CmdbBaseItems_ClientItemId",
                        column: x => x.ClientItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbBaseItems_CmdbBaseItems_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbBaseItems_CmdbBaseItems_CompanyItemId",
                        column: x => x.CompanyItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CmdbBaseItems_CmdbBaseItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_CmdbBaseItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "public",
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                schema: "public",
                columns: table => new
                {
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Version = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Vendor = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CmdbConfigurationItemId = table.Column<Guid>(type: "uuid", nullable: false),
                    ClientId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_ClientAccounts_ClientId",
                        column: x => x.ClientId,
                        principalSchema: "public",
                        principalTable: "ClientAccounts",
                        principalColumn: "ClientAccountId");
                    table.ForeignKey(
                        name: "FK_Applications_CmdbBaseItems_CmdbConfigurationItemId",
                        column: x => x.CmdbConfigurationItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "public",
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "Inquiries",
                schema: "public",
                columns: table => new
                {
                    InquiryId = table.Column<Guid>(type: "uuid", nullable: false),
                    Subject = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Channel = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ClientAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    CmdbClientItemId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiries", x => x.InquiryId);
                    table.ForeignKey(
                        name: "FK_Inquiries_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalSchema: "public",
                        principalTable: "ClientAccounts",
                        principalColumn: "ClientAccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inquiries_CmdbBaseItems_CmdbClientItemId",
                        column: x => x.CmdbClientItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SupportCases",
                schema: "public",
                columns: table => new
                {
                    SupportCaseId = table.Column<Guid>(type: "uuid", nullable: false),
                    CaseNumber = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Title = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Priority = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ClientAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConfigurationItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    CmdbClientItemId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportCases", x => x.SupportCaseId);
                    table.ForeignKey(
                        name: "FK_SupportCases_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalSchema: "public",
                        principalTable: "ClientAccounts",
                        principalColumn: "ClientAccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupportCases_CmdbBaseItems_CmdbClientItemId",
                        column: x => x.CmdbClientItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SupportCases_CmdbBaseItems_ConfigurationItemId",
                        column: x => x.ConfigurationItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "ServiceContracts",
                schema: "public",
                columns: table => new
                {
                    ServiceContractId = table.Column<Guid>(type: "uuid", nullable: false),
                    ContractNumber = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ContractName = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Type = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    ClientAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    ApplicationId = table.Column<Guid>(type: "uuid", nullable: true),
                    CmdbClientItemId = table.Column<Guid>(type: "uuid", nullable: true),
                    CmdbCompanyItemId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceContracts", x => x.ServiceContractId);
                    table.ForeignKey(
                        name: "FK_ServiceContracts_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "public",
                        principalTable: "Applications",
                        principalColumn: "ApplicationId");
                    table.ForeignKey(
                        name: "FK_ServiceContracts_ClientAccounts_ClientAccountId",
                        column: x => x.ClientAccountId,
                        principalSchema: "public",
                        principalTable: "ClientAccounts",
                        principalColumn: "ClientAccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ServiceContracts_CmdbBaseItems_CmdbClientItemId",
                        column: x => x.CmdbClientItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ServiceContracts_CmdbBaseItems_CmdbCompanyItemId",
                        column: x => x.CmdbCompanyItemId,
                        principalSchema: "public",
                        principalTable: "CmdbBaseItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ClientId",
                schema: "public",
                table: "Applications",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CmdbConfigurationItemId",
                schema: "public",
                table: "Applications",
                column: "CmdbConfigurationItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_ProductId",
                schema: "public",
                table: "Applications",
                column: "ProductId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_ClientAccountId",
                schema: "public",
                table: "Inquiries",
                column: "ClientAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_CmdbClientItemId",
                schema: "public",
                table: "Inquiries",
                column: "CmdbClientItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PortalUsers_ClientAccountId",
                schema: "public",
                table: "PortalUsers",
                column: "ClientAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ClientAccountId",
                schema: "public",
                table: "Products",
                column: "ClientAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                schema: "public",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceContracts_ApplicationId",
                schema: "public",
                table: "ServiceContracts",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceContracts_ClientAccountId",
                schema: "public",
                table: "ServiceContracts",
                column: "ClientAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceContracts_CmdbClientItemId",
                schema: "public",
                table: "ServiceContracts",
                column: "CmdbClientItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceContracts_CmdbCompanyItemId",
                schema: "public",
                table: "ServiceContracts",
                column: "CmdbCompanyItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_ClientAccountId",
                schema: "public",
                table: "SupportCases",
                column: "ClientAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_CmdbClientItemId",
                schema: "public",
                table: "SupportCases",
                column: "CmdbClientItemId");

            migrationBuilder.CreateIndex(
                name: "IX_SupportCases_ConfigurationItemId",
                schema: "public",
                table: "SupportCases",
                column: "ConfigurationItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inquiries",
                schema: "public");

            migrationBuilder.DropTable(
                name: "PortalUsers",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ServiceContracts",
                schema: "public");

            migrationBuilder.DropTable(
                name: "SupportCases",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Applications",
                schema: "public");

            migrationBuilder.DropTable(
                name: "CmdbBaseItems",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ClientAccounts",
                schema: "public");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "public");
        }
    }
}
