using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMatrix.WebData;

namespace SP.Labo.Web.Controllers
{
    public class R3OAuthController : Controller
    {
        //
        // GET: /R3OAuth/

        public ActionResult Index()
        {
            ViewBag.returnUrl = Request.Url.AbsoluteUri;
            return View();
        }

    }
}
