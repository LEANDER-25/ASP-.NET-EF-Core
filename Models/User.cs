using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DEMO_EF_Core.Models
{
    [Index(nameof(Username), Name = "unique_username", IsUnique = true)]
    public partial class User
    {
        public User()
        {
            Ratings = new HashSet<Rating>();
        }

        [Key]
        [Column("user_id")]
        public int UserId { get; set; }
        [Column("username")]
        [StringLength(100)]
        public string Username { get; set; }
        [Column("password")]
        [StringLength(100)]
        public string Password { get; set; }
        [EmailAddress]
        [Column("email")]
        [StringLength(20)]
        public string Email { get; set; }
        [Column("phone")]
        [StringLength(10)]
        public string Phone { get; set; }

        [InverseProperty(nameof(Rating.User))]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
