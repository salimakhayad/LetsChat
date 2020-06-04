﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Domain
{
    public class GroupProfile
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("Profile")]
        public string ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        [ForeignKey("Group")]
        public string GroupId { get; set; }
        public virtual Group Group { get; set; }
      
    }
}
