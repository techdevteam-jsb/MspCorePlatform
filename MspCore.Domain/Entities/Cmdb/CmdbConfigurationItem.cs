using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbConfigurationItem : CmdbBaseItem
    {
        [Required]
        public string ConfigurationId { get; set; } = string.Empty; // Logical unique CI code

        [Required]
        public string Environment { get; set; } = "Production"; // Dev, Test, Prod, etc.

        [Required]
        public string Category { get; set; } = string.Empty; // Hardware, Software, etc.

        public string? Subcategory { get; set; }
        public string? Criticality { get; set; } // High, Medium, Low
        public string? OperationalStatus { get; set; } // Online, Offline, etc.

        public DateTime? InstallDate { get; set; }
        public DateTime? LastScanDate { get; set; }

        public string? ManagedBy { get; set; }
        public string? BusinessUnit { get; set; }
        public string? LifecyclePhase { get; set; }
        public string? SupportGroup { get; set; }
        public string? CostCenter { get; set; }
        public string? UsageType { get; set; } // Internal, Customer-Facing

        public bool IsVirtual { get; set; }

    }
}