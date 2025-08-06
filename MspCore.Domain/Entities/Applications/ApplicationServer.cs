using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MspCore.Domain.Entities.Cmdb;

namespace MspCore.Domain.Entities.Applications
{
 public class ApplicationServer : CmdbConfigurationItem
    {
        public Guid ApplicationServerId { get; set; }

        [Required]
        public Guid ApplicationItemId { get; set; }

        [MaxLength(100)]
        public string ServerType { get; set; } = null!;

        [MaxLength(100)]
        public string Hostname { get; set; } = null!;

        [MaxLength(100)]
        public string IPAddress { get; set; } = null!;

        [MaxLength(50)]
        public string OS { get; set; } = null!;

        [MaxLength(100)]
        public string Version { get; set; } = null!;


        public DateTime? CommissionedDate { get; set; }

        public DateTime? DecommissionedDate { get; set; }

        [ForeignKey("ApplicationItemId")]
        public virtual CmdbApplicationItem ApplicationItem { get; set; } = null!;
    }
}
