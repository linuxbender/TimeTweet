﻿using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;

namespace Ch.TimeTweet.Domain.Entity.MasterData
{
    public class Company : BaseEntity
    {        
        [Required]
        [StringLength(Number.MaxLength60)]
        public string Name { get; set; }

        [StringLength(Number.MaxLength60)]
        public string ShortName { get; set; }
    }
}
