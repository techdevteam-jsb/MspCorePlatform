using System.ComponentModel.DataAnnotations;
using MspCore.Domain.Entities.Support;
using MspCore.Domain.Entities.Contracts;
using MspCore.Domain.Entities.Applications;
using MspCore.Domain.Entities.Products;


namespace MspCore.Domain.Entities.Clients
{
    public class ClientAccount
    {
        [Key]
        public Guid ClientAccountId { get; set; }

        [Required]
        [MaxLength(150)]
        public string AccountName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? AccountCode { get; set; }

        [MaxLength(150)]
        public string? ContactEmail { get; set; }

        [MaxLength(50)]
        public string? PhoneNumber { get; set; }

        [MaxLength(100)]
        public string? Status { get; set; } // Active, Inactive

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        // Navigation Properties
        public ICollection<ServiceContract>? ServiceContracts { get; set; }
        public ICollection<SupportCase>? SupportCases { get; set; }
        public ICollection<Inquiry>? Inquiries { get; set; }
        public ICollection<PortalUser>? PortalUsers { get; set; }
        public ICollection<Application>? Applications { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}