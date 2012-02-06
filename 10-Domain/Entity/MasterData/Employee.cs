using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;
using Ch.TimeTweet.Domain.Entity.TimeClock;

namespace Ch.TimeTweet.Domain.Entity.MasterData
{
    public class Employee : BaseEntity
    {
        [StringLength(Number.MaxLength60)]
        public string FirstName { get; set; }

        [StringLength(Number.MaxLength60)]
        public string LastName { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<TimeCard> TimeCard { get; set; }
    }
}