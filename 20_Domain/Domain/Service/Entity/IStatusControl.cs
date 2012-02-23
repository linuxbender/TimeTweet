using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch.TimeTweet.Domain.Service.Entity
{
    public interface IStatusControl
    {
        bool Aktiv { get; set; }
        bool Archived { get; set; }
        bool InAktiv { get; set; }
    }
}
