using System.Web.Mvc;

namespace EasyLOB
{
    public class MyLOBProfileAttribute : ActionFilterAttribute // !!!
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }
}