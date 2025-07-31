using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MspCore.Domain.Entities.Cmdb;
using MspCore.Domain.Entities.Products;
using MspCore.Domain.Entities.Clients;
using MspCore.Domain.Entities.Contracts;


namespace MspCore.Domain.Entities.Applications
{
    public class Application
    {
        [Key]
        public Guid ApplicationId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? Version { get; set; }

        [MaxLength(100)]
        public string? Vendor { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; } // e.g., Active, Deprecated

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdated { get; set; }

        // Relationships

        [ForeignKey(nameof(CmdbConfigurationItem))]
        public Guid CmdbConfigurationItemId { get; set; }
        public CmdbConfigurationItem? CmdbConfigurationItem { get; set; }

        [ForeignKey(nameof(Client))]
        public Guid? ClientId { get; set; }
        public ClientAccount? Client { get; set; }


        [ForeignKey(nameof(Product))]
        public Guid? ProductId { get; set; }
        public Product? Product { get; set; }

        public ICollection<ServiceContract> Contracts { get; set; } = new List<ServiceContract>();
    }
}