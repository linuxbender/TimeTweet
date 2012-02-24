using System;
using System.ComponentModel.DataAnnotations;
using Ch.TimeTweet.CrossCutting.Common.Constant;
using Ch.TimeTweet.Domain.Service.Entity;

namespace Ch.TimeTweet.Domain.Entity
{
    public abstract class BaseEntity : IEntity, IConcurrencyControl, ITimeStampsControl, IUpdateControl
    {
        /// <summary>
        /// IEntity
        /// </summary>
        [Key]
        [Required]
        public virtual int Id { get; set; }

        /// <summary>
        /// IConcurrencyControl
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// ITimeStampsControl
        /// </summary>        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// IUpdateControl
        /// </summary>
        [Required]
        [StringLength(Number.MaxLength60)]
        public string CreatedBy { get; set; }
        [Required]
        [StringLength(Number.MaxLength60)]
        public string UpdatedBy { get; set; }
    }
}