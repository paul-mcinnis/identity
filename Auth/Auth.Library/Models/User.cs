﻿using Auth.Library.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auth.Library.Models
{
    public class User : IUser
    {
        [Column("user_id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ModelId { get; set; }
        
        [Column("user_name")]
        [StringLength(50, MinimumLength = 3)]
        public string UserName { get; set; }

        [Column("active")]
        public bool? IsActive { get; set; }
    }
}
