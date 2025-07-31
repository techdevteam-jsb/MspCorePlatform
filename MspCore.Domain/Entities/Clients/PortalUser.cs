using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MspCore.Domain.Entities.Clients
{
    public class PortalUser
    {
        [Key]
        public Guid PortalUserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Role { get; set; }

        [MaxLength(100)]
        public string? FirstName { get; set; }

        [MaxLength(100)]
        public string? LastName { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Foreign Key to ClientAccount
        [ForeignKey(nameof(ClientAccount))]
        public Guid ClientAccountId { get; set; }

        public ClientAccount? ClientAccount { get; set; }
    }
}
