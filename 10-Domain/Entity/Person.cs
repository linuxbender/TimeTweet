using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;

namespace Ch.TimeTweet.Domain.Entity
{
    public class Person : BaseEntity
    {
        [StringLength(Number.MaxLength60)]
        public string FirstName { get; set; }

        [StringLength(Number.MaxLength60)]
        public string LastName { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<TimeCard> Times { get; set; }
    }
}