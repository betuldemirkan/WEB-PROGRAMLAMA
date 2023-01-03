using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_PROGRAMLAMA.Models;

namespace WEB_PROGRAMLAMA.Controllers
{
    public class AdminController : Controller
    {
        KurumsalDBEntities db = new KurumsalDBEntities();
        // GET: Admin
        public ActionResult Index()
        {
            var sorgu = db.Kategoris.ToList();
            return View(sorgu);
        }
    }
}