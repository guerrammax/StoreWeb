using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppStoreWeb.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Detail(int ID=1)
        {
            var Model = BL.Product.GetByID(ID);

            return View(Model);
        }
    }
}