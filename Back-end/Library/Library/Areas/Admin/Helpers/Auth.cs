using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Areas.Admin.Helpers
{
    public class Auth:ActionFilterAttribute
    {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["isLogin"]==null ||(bool)HttpContext.Current.Session["isLogin"]==false)
            {
                filterContext.Result = new RedirectResult("Login");
            }
            base.OnActionExecuting(filterContext);
        }



    }
}