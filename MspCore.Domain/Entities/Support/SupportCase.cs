using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MspCore.Domain.Entities.Cmdb;
using MspCore.Domain.Entities.Clients;

namespace MspCore.Domain.Entities.Support
{
    public class SupportCase
    {
        [Key]
        public Guid SupportCaseId { get; set; }

        [Required]
        [MaxLength(150)]
        public string CaseNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(1000)]
        public string? Description { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; } // Open, Resolved, Closed

        [MaxLength(50)]
        public string? Priority { get; set; } // Low, Medium, High

        [Required]
        public Guid ClientAccountId { get; set; }

        [ForeignKey(nameof(ClientAccountId))]
        public ClientAccount? ClientAccount { get; set; }

        public Guid? ConfigurationItemId { get; set; }

        [ForeignKey(nameof(ConfigurationItemId))]
        public CmdbConfigurationItem? ConfigurationItem { get; set; }
    }
}