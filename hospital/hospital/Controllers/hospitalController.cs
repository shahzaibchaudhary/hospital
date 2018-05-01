using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hospital.Controllers
{
    public class hospitalController : Controller
    {
        // GET: hospital
        public ActionResult Index()
        {
            return View();
        }

        // GET: hospital/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: hospital/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: hospital/Create
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

        // GET: hospital/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: hospital/Edit/5
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

        // GET: hospital/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: hospital/Delete/5
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
