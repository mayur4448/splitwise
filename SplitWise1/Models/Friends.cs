using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace SplitWise1.Models
{
    public class Friends
    {
        
        [Required]

        public string FriendName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        [Key]
        public string Email { get; set; }
    }

    public class FriendsDBContext : DbContext
    {
        public DbSet<Friends>Friends{ get; set; }

        protected override void OnModelCreating(DbModelBuilder DbModelBuilder)
        {
            DbModelBuilder.Entity<Friends>().HasKey(x => x.Email);
            base.OnModelCreating(DbModelBuilder);
        }
    }
}