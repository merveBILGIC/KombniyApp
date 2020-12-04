﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KombniyAppAccount.Models
{
        public class UserMates 
        {
            public int Id { get; set; }
            public User User { get; set; }

            public int UserId { get; set; }

            public User Mate { get; set; }

            public int MateId { get; set; }

            public State State { get; set; }
        }
        public enum State
        {
            NoConnection,
            RequestSent,
            Friend
        };
    
}