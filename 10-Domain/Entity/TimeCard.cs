using System;
using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;

namespace Ch.TimeTweet.Domain.Entity
{
    public class TimeCard : BaseEntity
    {        
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [StringLength(Number.MaxLength100)]
        public string Name { get; set; }

        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
    }
}
