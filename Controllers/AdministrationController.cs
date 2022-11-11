using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NetFramework;
using NetFramework.Migrations;
using NetFramework.Repository;

namespace NET_Framework.Controllers
{

    public class AdministrationController : Controller
    {
        //inicio de el controlador 
        //private FrameworkContext db=new FrameworkContext(); //conexion a la base de datos
       
        public AdministrationController()
        {
        }
        
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
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //public ActionResult CreateProductos()
        //{
        //    return View();
        //}

        //// POST: Administration/Create
        //[HttpPost]
        //public ActionResult CreateProductos([Bind(Include = "Id,Name,Descripcion,Price,Tax")] Product product)
        //{

        //    return View(product);
        //}

        //public ActionResult listaCompany()
        //{
        //    return View();
        //}

        ////todos los productos se deben crear 
        //public ActionResult listaProductos()
        //{
        //    return View();
        //}
        //// GET: Administration/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Administration/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Administration/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Administration/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
