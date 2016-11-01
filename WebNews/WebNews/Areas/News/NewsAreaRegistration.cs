using System.Web.Mvc;

namespace WebNews.Areas.News
{
    public class NewsAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "News";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "News_default",
                "News/{controller}/{action}/{id}",
                new { controller = "News", action = "Index", id = UrlParameter.Optional }
            );
            context.MapRoute(
               name: "Default1",
               url: "{controller}/{action}/{id}",
               defaults: new { area = "News", controller = "News", action = "Index", id = UrlParameter.Optional }

           );
        }
    }
}