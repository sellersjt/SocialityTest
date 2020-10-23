﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sociality.Data
{
    public class TheUser
    {
        [Key]
        public int UserKey { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
