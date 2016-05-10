using MVCBlog.Areas.Admin.Models.Attributes;
using MVCBlog.Models.ORM.Context;
using MVCBlog.Models.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBlog.Areas.Admin.Controllers
{

    [LoginControl]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {

            //BlogContext db = new BlogContext();

            //AdminUser adminUser = db.AdminUsers.FirstOrDefault(x => x.Email == HttpContext.User.Identity.Name);
            //ViewBag.Name = adminUser.Name;
            //ViewBag.Surname = adminUser.Surname;

            return View();
        }
    }
}