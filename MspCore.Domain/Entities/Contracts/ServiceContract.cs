using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MspCore.Domain.Entities.Clients;



namespace MspCore.Domain.Entities.Contracts
{
    public class ServiceContract
    {
        [Key]
        public Guid ServiceContractId { get; set; }

        [Required]
        [MaxLength(200)]
        public string ContractNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string ContractName { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; } // Active, Expired, etc.

        [MaxLength(100)]
        public string? Type { get; set; }

        [MaxLength(500)]
        public string? Notes { get; set; }


        [Required]
        public Guid ClientAccountId { get; set; }

        [ForeignKey(nameof(ClientAccountId))]
        public ClientAccount? ClientAccount { get; set; }

    }
}
