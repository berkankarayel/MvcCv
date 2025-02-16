using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
		// GET: Default

        // Hakkımda 
		DbCvEntities1 db = new DbCvEntities1();
		public ActionResult Index()
        {
           var degerler = db.TblHakkimda.ToList();
            return View(degerler);
        }


        // Deneyimlerim 
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.TblDeneyimlerim.ToList();
            return PartialView(deneyimler);
        }

        // Eğitimlerim 
		public PartialViewResult Egitimlerim()
		{
			var egitimler = db.TblEgitim.ToList();
			return PartialView(egitimler);
		}



	}
}