using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppStoreWeb.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Blog
        public ActionResult Detail(int ID=1)
        {
            var Model = BL.BLogPostBL.GetByID(ID);

            return View(Model);
        }

        [HttpPost]
        public ActionResult Create(BlogPost blogPost)
        {
            try
            {
                BL.BLogPostBL.GuardarBlogPost(blogPost);
            }

            
            catch (Exception)
            {

                throw;
                
            }
            return View();
        }
    }
}