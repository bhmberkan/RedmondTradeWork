using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedmondTradeWork.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Kullanıcı session'ı kontrol et
            if (Session["UserRole"] == null || Session["UserRole"].ToString() !="admin" && Session["UserRole"].ToString() != "member")
            {
                // Eğer giriş yapılmamışsa, Login sayfasına yönlendir
                filterContext.Result = new RedirectToRouteResult(
                    new System.Web.Routing.RouteValueDictionary(
                        new { controller = "Login", action = "Index" }
                    )
                );
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
