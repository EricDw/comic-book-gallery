using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ActionResult _result;
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                _result = Redirect("/");
            }
            else
            {
                _result = Content("Hello  from the controller!");
            }

            return _result;
        }
    }
}