using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;

namespace Ch.TimeTweet.Domain.Entity.MasterData
{
    public class State : BaseEntity
    {
        [Required]
        [StringLength(Number.MaxLength80)]
        public string Name { get; set; }

        [Required]
        [StringLength(Number.MaxLength10)]
        public string ShortName { get; set; }
    }
}