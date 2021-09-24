using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DEMO_EF_Core.Models
{
    [Table("Rating")]
    public partial class Rating
    {
        [Key]
        [Column("rate_id")]
        public int RateId { get; set; }
        [Column("user_id")]
        public int? UserId { get; set; }
        [Column("product_id")]
        public int? ProductId { get; set; }
        [Column("star")]
        public int? Star { get; set; }
        [Column("comment")]
        [StringLength(255)]
        public string Comment { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Ratings")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Ratings")]
        public virtual User User { get; set; }
    }
}
