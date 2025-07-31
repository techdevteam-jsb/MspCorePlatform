using System.ComponentModel.DataAnnotations;
using MspCore.Domain.Entities.Contracts;
using MspCore.Domain.Entities.Support;

namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbClientItem : CmdbConfigurationItem
    {
        [Required]
        [MaxLength(150)]
        public string ClientName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Country { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? Region { get; set; }

        [MaxLength(150)]
        public string? PrimaryContact { get; set; }

        [MaxLength(150)]
        public string? Email { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }

        [MaxLength(150)]
        public string? AccountManager { get; set; }

        [Required]
        [MaxLength(50)]
        public string ClientStatus { get; set; } = "Active"; // Active, Inactive

        public ICollection<CmdbApplicationItem>? Applications { get; set; }
        public ICollection<CmdbProductItem>? Products { get; set; }
        public ICollection<ServiceContract>? ServiceContracts { get; set; }
        public ICollection<SupportCase>? SupportCases { get; set; }
        public ICollection<Inquiry>? Inquiries { get; set; }
    }
}