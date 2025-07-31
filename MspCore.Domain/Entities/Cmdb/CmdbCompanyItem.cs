using System;
using System.ComponentModel.DataAnnotations;
using MspCore.Domain.Entities.Contracts;


namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbCompanyItem : CmdbConfigurationItem
    {
        [Required]
        [MaxLength(200)]
        public string CompanyName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? RegistrationNumber { get; set; }

        [MaxLength(300)]
        public string? HeadquartersLocation { get; set; }

        [MaxLength(100)]
        public string? IndustryType { get; set; }

        [MaxLength(300)]
        public string? WebsiteUrl { get; set; }

        [MaxLength(150)]
        public string? ContactEmail { get; set; }

        [MaxLength(50)]
        public string? ContactPhone { get; set; }

        [MaxLength(150)]
        public string? CEOName { get; set; }

        public DateTime? EstablishedDate { get; set; }

        [MaxLength(50)]
        public string? BusinessStatus { get; set; } // e.g., Active, Dormant, Closed

        // Navigation \
        public ICollection<CmdbApplicationItem>? Applications { get; set; }
        public ICollection<CmdbProductItem>? Products { get; set; }
        public ICollection<ServiceContract>? ServiceContracts { get; set; }

    }
}