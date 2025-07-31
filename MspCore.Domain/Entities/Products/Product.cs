using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MspCore.Domain.Entities.Cmdb;
using MspCore.Domain.Entities.Applications;


namespace MspCore.Domain.Entities.Products
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(150)]
        public string ProductName { get; set; } = string.Empty;

        [MaxLength(100)]
        public string? ProductCode { get; set; }

        [MaxLength(300)]
        public string? Description { get; set; }

        [MaxLength(100)]
        public string? Category { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        public decimal? Price { get; set; }


        public Guid? ProductCategoryId { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        public ProductCategory? ProductCategory { get; set; }

        public ICollection<CmdbProductItem>? InstallBaseItems { get; set; }
        public ICollection<Application>? Applications { get; set; }
    }
}