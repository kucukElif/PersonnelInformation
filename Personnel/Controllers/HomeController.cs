using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL.Context;

namespace Personnel.Controllers
{
    //tanımlamış olduğun katmanın adı ile aynı olduğundan dolayı classı ayıramıyoru
    public class HomeController : Controller
    {
        
        AppDbContext db = new AppDbContext();
        public ActionResult Index()
        {
            return View(db.Personnels.ToList());
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(DAL.Entity.Personnel personnel)
        {
            
                db.Personnels.Add(personnel);
                db.SaveChanges();
            
            
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var personel = db.Personnels.Find(id);
            db.Personnels.Remove(personel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BringPersonnel(int id)
        {
            var personel = db.Personnels.Find(id);
            
            return View("BringPersonnel", personel);

        }
        public ActionResult Update(DAL.Entity.Personnel p)
        {
            var personel = db.Personnels.Find(p.ID);
            personel.Name = p.Name;
            personel.Surname = p.Surname;
            personel.PhoneNumber = p.PhoneNumber;
            personel.Title = p.Title;
            personel.Address = p.Address;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}