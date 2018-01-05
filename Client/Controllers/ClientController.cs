using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Client.Controllers
{
   public class ClientController : Controller
   {
      // GET: Client
      public ActionResult Index()
      {
         var model = BusinessLogic.ClientManager.GetAll();
         return View(model);
      }

      // GET: Client/Details/5
      public ActionResult Details(int id)
      {
         return View();
      }

      // GET: Client/Create
      public ActionResult Create()
      {
         return View();
      }

      // POST: Client/Create
      [HttpPost]
      public ActionResult Create(FormCollection collection)
      {
         try
         {
            // TODO: Add insert logic here

            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }

      // GET: Client/Edit/5
      public ActionResult Edit(int id)
      {
         var model = BusinessLogic.ClientManager.GetById(id);
         // model.City = new SelectList(BusinessLogic.ClientManager.GetAll(), "CityId", "CityDesc");
         return View(model);
      }

      // POST: Client/Edit/5
      [HttpPost]
      public ActionResult Edit(int id, Entity.Client obj)//FormCollection collection
      {
         try
         {
            // TODO: Add update logic here
            BusinessLogic.ClientManager.Update(obj);

            return RedirectToAction("Index");
         }
         catch (Exception xp)
         {
            return View();
         }
      }

      // GET: Client/Delete/5
      public ActionResult Delete(int id)
      {
         return View(BusinessLogic.ClientManager.GetById(id));
      }

      // POST: Client/Delete/5
      [HttpPost]
      public ActionResult Delete(int id, FormCollection collection)
      {
         try
         {
            // TODO: Add delete logic here
            BusinessLogic.ClientManager.DeleteById(BusinessLogic.ClientManager.GetById(id));
            return RedirectToAction("Index");
         }
         catch
         {
            return View();
         }
      }
   }
}
