using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
using MvcCv.Repositories;


namespace MvcCv.Controllers
{
    public class YetenekController : Controller
    {
        // GET: Yetenek
        // Entity yukarıda çağırdık. Burada db değişkene atadık bu sayede kullanbilecez.
     
        GenericRepository<TblYeteneklerim> repo = new GenericRepository<TblYeteneklerim>();
        public ActionResult Index()
        {
            var yetnekler = repo.List();
            return View(yetnekler);
        }
    }
}