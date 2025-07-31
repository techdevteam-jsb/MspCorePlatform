using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MspCore.Domain.Entities.Clients;

namespace MspCore.Domain.Entities.Support
{
    public class Inquiry
    {
        [Key]
        public Guid InquiryId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Subject { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Channel { get; set; } // e.g., Email, Web, Phone

        [MaxLength(50)]
        public string? Status { get; set; } // e.g., New, Responded, Closed

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        [Required]
        public Guid ClientAccountId { get; set; }

        [ForeignKey(nameof(ClientAccountId))]
        public ClientAccount? ClientAccount { get; set; }
    }
}