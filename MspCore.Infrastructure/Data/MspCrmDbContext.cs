using Microsoft.EntityFrameworkCore;
using MspCore.Domain.Entities.Applications;
using MspCore.Domain.Entities.Clients;
using MspCore.Domain.Entities.Contracts;
using MspCore.Domain.Entities.Cmdb;
using MspCore.Domain.Entities.Products;
using MspCore.Domain.Entities.Support;

namespace MspCore.Infrastructure.Data
{
    public class MspCrmDbContext : DbContext
    {
        public MspCrmDbContext(DbContextOptions<MspCrmDbContext> options)
            : base(options) { }

        // CMDB
        public DbSet<CmdbBaseItem> CmdbBaseItems => Set<CmdbBaseItem>();
        public DbSet<CmdbConfigurationItem> CmdbConfigurationItems => Set<CmdbConfigurationItem>();
        public DbSet<CmdbApplicationItem> CmdbApplicationItems => Set<CmdbApplicationItem>();
        public DbSet<CmdbClientItem> CmdbClientItems => Set<CmdbClientItem>();
        public DbSet<CmdbCompanyItem> CmdbCompanyItems => Set<CmdbCompanyItem>();
        public DbSet<CmdbProductItem> CmdbProductItems => Set<CmdbProductItem>();

        // Clients
        public DbSet<ClientAccount> ClientAccounts => Set<ClientAccount>();
        public DbSet<PortalUser> PortalUsers => Set<PortalUser>();

        // Products
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();

        // Applications
        public DbSet<Application> Applications => Set<Application>();

        // Contracts
        public DbSet<ServiceContract> ServiceContracts => Set<ServiceContract>();

        // Support
        public DbSet<SupportCase> SupportCases => Set<SupportCase>();
        public DbSet<Inquiry> Inquiries => Set<Inquiry>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("public");

            // Inheritance hierarchy
            modelBuilder.Entity<CmdbBaseItem>().ToTable("CmdbBaseItems");
            modelBuilder.Entity<CmdbConfigurationItem>().ToTable("CmdbConfigurationItems");
            modelBuilder.Entity<CmdbApplicationItem>().ToTable("CmdbApplicationItems");
            modelBuilder.Entity<CmdbClientItem>().ToTable("CmdbClientItems");
            modelBuilder.Entity<CmdbCompanyItem>().ToTable("CmdbCompanyItems");
            modelBuilder.Entity<CmdbProductItem>().ToTable("CmdbProductItems");


            // CmdbApplicationItem relationships
            modelBuilder.Entity<CmdbApplicationItem>()
                .HasOne(a => a.Client)
                .WithMany(c => c.Applications)
                .HasForeignKey(a => a.ClientItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CmdbApplicationItem>()
                .HasOne(a => a.Company)
                .WithMany(c => c.Applications)
                .HasForeignKey(a => a.CompanyItemId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CmdbApplicationItem>()
                .HasOne(a => a.Product)
                .WithMany(p => p.Applications)
                .HasForeignKey(a => a.ProductItemId)
                .OnDelete(DeleteBehavior.SetNull);

            // PortalUser → ClientAccount
            modelBuilder.Entity<PortalUser>()
                .HasOne(p => p.ClientAccount)
                .WithMany(c => c.PortalUsers)
                .HasForeignKey(p => p.ClientAccountId)
                .OnDelete(DeleteBehavior.Cascade);

            // SupportCase → ClientAccount
            modelBuilder.Entity<SupportCase>()
                .HasOne(s => s.ClientAccount)
                .WithMany(c => c.SupportCases)
                .HasForeignKey(s => s.ClientAccountId)
                .OnDelete(DeleteBehavior.Cascade);

            // SupportCase → CmdbConfigurationItem (optional)
            modelBuilder.Entity<SupportCase>()
                .HasOne(s => s.ConfigurationItem)
                .WithMany()
                .HasForeignKey(s => s.ConfigurationItemId)
                .OnDelete(DeleteBehavior.SetNull);

            // Inquiry → ClientAccount
            modelBuilder.Entity<Inquiry>()
                .HasOne(i => i.ClientAccount)
                .WithMany(c => c.Inquiries)
                .HasForeignKey(i => i.ClientAccountId)
                .OnDelete(DeleteBehavior.Cascade);

            // ServiceContract → ClientAccount
            modelBuilder.Entity<ServiceContract>()
                .HasOne(s => s.ClientAccount)
                .WithMany(c => c.ServiceContracts)
                .HasForeignKey(s => s.ClientAccountId)
                .OnDelete(DeleteBehavior.Restrict);

            // Product → ProductCategory
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductCategory)
                .WithMany(pc => pc.Products)
                .HasForeignKey(p => p.ProductCategoryId)
                .OnDelete(DeleteBehavior.SetNull);

            // CmdbProductItem → CmdbCompanyItem
            modelBuilder.Entity<CmdbProductItem>()
                .HasOne(p => p.Company)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            // CmdbProductItem → CmdbClientItem
            modelBuilder.Entity<CmdbProductItem>()
                .HasOne(p => p.Client)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
