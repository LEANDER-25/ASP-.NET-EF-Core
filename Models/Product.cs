using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DEMO_EF_Core.Models
{
    public partial class Product
    {
        public Product()
        {
            Ingredients = new HashSet<Ingredient>();
            Ratings = new HashSet<Rating>();
        }

        [Key]
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("product_name")]
        [StringLength(255)]
        public string ProductName { get; set; }
        [Column("price", TypeName = "decimal(18, 0)")]
        public decimal? Price { get; set; }

        [InverseProperty(nameof(Ingredient.Product))]
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        [InverseProperty(nameof(Rating.Product))]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
