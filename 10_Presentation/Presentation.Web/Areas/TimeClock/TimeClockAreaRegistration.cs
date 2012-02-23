using System.Web.Mvc;

namespace Ch.TimeTweet.Presentation.Web.Areas.TimeClock
{
    public class TimeClockAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "TimeClock";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "TimeClock_default",
                "TimeClock/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
