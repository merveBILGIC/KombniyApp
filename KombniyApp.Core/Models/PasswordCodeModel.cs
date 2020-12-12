using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace KombniyApp.Core.Models
{
	public class PasswordCodeModel
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
