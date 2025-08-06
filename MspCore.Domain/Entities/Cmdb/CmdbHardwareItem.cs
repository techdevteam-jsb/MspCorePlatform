using System;
using System.ComponentModel.DataAnnotations;

namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbHardwareItem : CmdbConfigurationItem
    {
        [MaxLength(100)]
        public required string Manufacturer { get; set; }

        [MaxLength(100)]
        public required string Model { get; set; }

        [MaxLength(50)]
        public required string SerialNumber { get; set; }

        [MaxLength(100)]
        public required string HardwareType { get; set; }

    }
}
