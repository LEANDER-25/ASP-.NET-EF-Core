using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DEMO_EF_Core.Models
{
    [Keyless]
    public partial class OverviewProductRating
    {
        [Column("product_id")]
        public int? ProductId { get; set; }
        [Column("five")]
        public int? Five { get; set; }
        [Column("four")]
        public int? Four { get; set; }
        [Column("three")]
        public int? Three { get; set; }
        [Column("two")]
        public int? Two { get; set; }
        [Column("one")]
        public int? One { get; set; }
        [Column("avg_star")]
        public int? AvgStar { get; set; }
    }
}
