using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MspCore.Domain.Entities.Products
{
    public class ProductCategory
    {
        [Key]
        public Guid ProductCategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product>? Products { get; set; }
    }
}