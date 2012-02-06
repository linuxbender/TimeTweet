using System;
using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;
using Ch.TimeTweet.Domain.Entity.MasterData;

namespace Ch.TimeTweet.Domain.Entity.TimeClock
{
    public class TimeCard : BaseEntity
    {        
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [StringLength(Number.MaxLength60)]
        public string Name { get; set; }

        public int PersonId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
