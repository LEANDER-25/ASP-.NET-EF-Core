using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DEMO_EF_Core.Models
{
    public partial class Ingredient
    {
        [Key]
        [Column("ingredient_id")]
        public int IngredientId { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("material_id")]
        public int MaterialId { get; set; }
        [Column("quantity")]
        public double? Quantity { get; set; }
        [Column("is_main")]
        public bool IsMain { get; set; }

        [ForeignKey(nameof(MaterialId))]
        [InverseProperty("Ingredients")]
        public virtual Material Material { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Ingredients")]
        public virtual Product Product { get; set; }
    }
}
