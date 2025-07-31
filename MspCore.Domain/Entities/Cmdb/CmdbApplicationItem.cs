using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbApplicationItem : CmdbConfigurationItem
    {
        [Required]
        [MaxLength(150)]
        public string ApplicationName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Version { get; set; }

        [MaxLength(100)]
        public string? Platform { get; set; } // .NET, Java, PHP

        [MaxLength(150)]
        public string? BusinessOwner { get; set; }

        [MaxLength(150)]
        public string? TechnicalOwner { get; set; }

        public DateTime? ReleaseDate { get; set; }

        [MaxLength(100)]
        public string? SupportStatus { get; set; } // Supported, Deprecated, etc.

        [MaxLength(50)]
        public string? HostingType { get; set; } // On-Prem, Cloud

        [MaxLength(50)]
        public string? ServiceTier { get; set; }

        // Relationship: used by a client
        public Guid? ClientItemId { get; set; }

        [ForeignKey("ClientItemId")]
        public CmdbClientItem? Client { get; set; }

        // Relationship: provided by a company
        public Guid? CompanyItemId { get; set; }

        [ForeignKey("CompanyItemId")]
        public CmdbCompanyItem? Company { get; set; }

        // Optional: Licensed Product reference
        public Guid? ProductItemId { get; set; }

        [ForeignKey("ProductItemId")]
        public CmdbProductItem? Product { get; set; }
    }
}