﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace KombniyAppAccount.Models
{
	public class PasswordCode
	{
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]

        [StringLength(6)]
        public string Code { get; set; }
        [Required]
        public DateTime GeneratedTime { get; set; } = DateTime.Now;
    }
}
