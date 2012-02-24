using System;
using Ch.TimeTweet.CrossCutting.Common.Constant;
using Ch.TimeTweet.Domain.Entity;
using Ch.TimeTweet.Domain.Entity.MasterData;

namespace Ch.TimeTweet.Database.Seed
{
    public static class SeedExtension
    {
        public static T SetBaseEntity<T>(this BaseEntity set) where T : class
        {
            set.CreatedAt = DateTime.Now;
            set.UpdatedAt = DateTime.Now;
            set.CreatedBy = StringConstant.System;
            set.UpdatedBy = StringConstant.System;
            return set as T;
        }
    }
}
