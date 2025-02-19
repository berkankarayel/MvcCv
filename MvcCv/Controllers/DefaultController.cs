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

		// Yeteneklerim 

		public PartialViewResult Yeteneklerim()
		{
			var yetenekler = db.TblYeteneklerim.ToList();
			return PartialView(yetenekler);
		}

		// Hobilerim 
		public PartialViewResult Hobilerim()
		{
			var hobiler = db.TblHobilerim.ToList();
			return PartialView(hobiler);
		}

		// Sertifikalar
		public PartialViewResult Sertifikalar()
		{
			var sertifikalar = db.TblSertifikalarim.ToList();
			return PartialView(sertifikalar);
		}

		// İletişim 
		[HttpGet]
		public PartialViewResult iletisim()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult iletisim(TblIletisim t)
		{
			t.Tarih=DateTime.Parse(DateTime.Now.ToShortDateString());
			db.TblIletisim.Add(t);
			db.SaveChanges();
			return PartialView();
		}




	}
}