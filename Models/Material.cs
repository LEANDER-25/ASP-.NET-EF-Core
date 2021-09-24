using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DEMO_EF_Core.Models
{
    public partial class Material
    {
        public Material()
        {
            Ingredients = new HashSet<Ingredient>();
        }

        [Key]
        [Column("material_id")]
        public int MaterialId { get; set; }
        [Required]
        [Column("material_name")]
        [StringLength(100)]
        public string MaterialName { get; set; }

        [InverseProperty(nameof(Ingredient.Material))]
        public virtual ICollection<Ingredient> Ingredients { get; set; }
    }
}
