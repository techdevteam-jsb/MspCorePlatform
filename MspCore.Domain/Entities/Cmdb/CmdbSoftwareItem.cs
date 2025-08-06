using System;
using System.ComponentModel.DataAnnotations;

namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbSoftwareItem : CmdbConfigurationItem
    {
        [MaxLength(200)]
        public required string SoftwareName { get; set; }

        [MaxLength(100)]
        public required string Version { get; set; }

        [MaxLength(100)]
        public required string LicenseKey { get; set; }

        [MaxLength(100)]
        public required string Vendor { get; set; }

        [MaxLength(50)]
        public required string LicenseType { get; set; } // e.g., Perpetual, Subscription
    }
}
