using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch.TimeTweet.Domain.Service.Entity
{
    public interface IConcurrencyControl
    {
        byte[] RowVersion { get; set; }
    }
}
