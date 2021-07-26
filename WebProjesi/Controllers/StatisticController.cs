using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProjesi.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        // GET: Statistics
        Context context = new Context();
        public ActionResult Statistic()
        {
            //Toplam kategori sayısı
            var deger1 = context.Categories.Count().ToString();
            ViewBag.deger1 = deger1;


            var deger2 = context.Headings.Count(x => x.CategoryId == 1).ToString();
            ViewBag.deger2 = deger2;


            var deger3 = context.Writers.Where(t => t.WriterName.Contains("a") || t.WriterName.Contains("A")).Count();
            ViewBag.deger3 = deger3;


            var deger4 = context.Categories.Where(m => m.CategoryId == context.Headings.GroupBy(x => x.CategoryId).OrderByDescending(x => x.Count())
               .Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.deger4 = deger4;


            var deger5 = context.Categories.Where(t => t.CategoryStatus == true).Count() - context.Categories.Where(t => t.CategoryStatus == false).Count();
            ViewBag.deger5 = deger5;
            return View();
        }
    }
}