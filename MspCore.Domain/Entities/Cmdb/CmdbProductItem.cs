using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbProductItem : CmdbConfigurationItem
    {
        [Required]
        [MaxLength(150)]
        public string ProductName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? ProductCode { get; set; }

        [MaxLength(150)]
        public string? Vendor { get; set; }

        [MaxLength(100)]
        public string? Version { get; set; }

        [MaxLength(100)]
        public string? WarrantyPeriod { get; set; }

        [MaxLength(100)]
        public string? LicenseType { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public bool IsActive { get; set; }

        [Required]
        public Guid CompanyId { get; set; }

        [ForeignKey(nameof(CompanyId))]
        public CmdbCompanyItem? Company { get; set; }

        [Required]
        public Guid ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public CmdbClientItem? Client { get; set; }

        public ICollection<CmdbApplicationItem>? Applications { get; set; }
    }
}