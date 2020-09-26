using Snipplets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Snipplets.Controllers
{
    public class HTMLHelpersController : Controller
    {
        public static HTMLHelpers OneItem = new HTMLHelpers();

        // GET: HTMLHelpers
        public ActionResult Index()
        {
            return View();
        }

        // GET: HTMLHelpers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HTMLHelpers/Create
        public ActionResult Test()
        {
            return View();
        }

        // POST: HTMLHelpers/Create
        [HttpPost]
        public ActionResult Test(HTMLHelpers data)
        {
            try
            {
                // TODO: Add insert logic here

                // Assign the given data to our storage
                OneItem = data;

                // ViewBag won't work: We call the View TestOutput ... so ViewBag looses its lifetime ...
                ViewBag.lstMembers = data.ListBox.ToList();
                TempData["lstMembers2"] = data.ListBox.ToList();

                
                List<string> olio = new List<string>();
                olio = data.ListBox.ToList();
                TempData["lstMembers2"] = olio; 

                return RedirectToAction("TestOutput");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult TestOutput()
        {
            return View(OneItem);
        }

        // GET: HTMLHelpers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HTMLHelpers/Create
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

        // GET: HTMLHelpers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HTMLHelpers/Edit/5
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

        // GET: HTMLHelpers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HTMLHelpers/Delete/5
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
