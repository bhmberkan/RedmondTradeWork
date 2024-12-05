using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedmondTradeWork.Controllers
{
    public class BaseController : Controller
    {
        protected override void ExecuteCore()
        {
            string culture = Request.QueryString["lang"] ?? "tr";

            if (string.IsNullOrEmpty(culture))
            {
                var cultureCookie = Request.Cookies["Culture"];
                culture = cultureCookie != null ? cultureCookie.Value : "tr";
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);

            base.ExecuteCore();
        }
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string lang = filterContext.HttpContext.Request.UserLanguages != null
                          ? filterContext.HttpContext.Request.UserLanguages[0]
                          : "tr";
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(lang);

            base.OnActionExecuting(filterContext);
        }

        public ActionResult ChangeLanguage(string lang)
        {
            if (!string.IsNullOrEmpty(lang))
            {
                HttpCookie cookie = new HttpCookie("Culture", lang);
                cookie.Expires = DateTime.Now.AddYears(1);
                Response.Cookies.Add(cookie);
            }
            return Redirect(Request.UrlReferrer.ToString());
        }

    }
}