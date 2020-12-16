using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KombniyApp.Core.Models
{
	public class PasswordCodeModel
	{
        [Key]
        public int PaswordId { get; set; }
         public User User { get; set; }
        

        //[ForeignKey]
        public int UserId { get; set; }

       
        [StringLength(6)]
        public string Code { get; set; }
        [Required]
        public DateTime GeneratedTime { get; set; } = DateTime.Now;
        
    }
}
