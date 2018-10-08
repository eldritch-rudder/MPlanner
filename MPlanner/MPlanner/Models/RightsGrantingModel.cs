﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MPlanner.Models
{
    public class RightsGrantingModel
    {
        [NotMapped]
        [Required]
        public string Email { get; set; }
    }
}
