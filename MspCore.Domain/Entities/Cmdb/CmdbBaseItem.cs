using System;
using System.ComponentModel.DataAnnotations;

namespace MspCore.Domain.Entities.Cmdb
{
    public class CmdbBaseItem
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public string Status { get; set; } = "Active"; // Active, Retired, Planned

        [Required]
        public string ItemType { get; set; } = string.Empty; // Application, Server, Product, etc.

        public string? Owner { get; set; }                 // Business or technical owner
        public string? Location { get; set; }              // Physical or logical location

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }

        public string? Tags { get; set; }                  // Comma-separated
        public string? Source { get; set; }                // Manual, Discovery, API, etc.
        public string? ReferenceCode { get; set; }         // Unique external ref like asset tag
        public string? Classification { get; set; }        // Public, Internal, Confidential, etc.
        public bool IsMonitored { get; set; }              // For health check flag

        public string? Notes { get; set; }                 // General comments or annotations
    }
}