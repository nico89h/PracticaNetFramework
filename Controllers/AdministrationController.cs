using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetFramework;
using NetFramework.Migrations;
namespace NET_Framework.Controllers
{

    public class AdministrationController : Controller
    {
        //inicio de el controlador 
        private FrameworkContext db=new FrameworkContext(); //conexion a la base de datos
        
        //controlador del index
        // GET: Administration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        // GET: Administration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administration/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,name,descripcion")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companys.Add(company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
        
        public ActionResult listaCompany()
        {
            return View(db.Companys.First());
        }

        // GET: Administration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administration/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administration/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
