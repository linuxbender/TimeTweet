using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;

namespace Ch.TimeTweet.Domain.Entity
{
    public class Company : BaseEntity
    {        
        [Required]
        [StringLength(Number.MaxLength60)]
        public string Name { get; set; }

        public ICollection<Person> Person { get; set; }
    }
}
