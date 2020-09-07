using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhoLiveApp.Models;
using WhoLivesApp.Models;

namespace WhoLivesApp.Controllers
{
    public class ReportsController : Controller
    {
        private ResContext db = new ResContext();

        // GET: Reports
        public ActionResult Report1()
        {

            var byapart = db.Database.SqlQuery<Report1>(
                "select MOR_ID ,MOR_NOME, MOR_SOBRENOME , AP_NUMERO , FUN_NOME from dbo.Residents INNER JOIN dbo.Apartaments ON AP_ID = MOR_AP_ID INNER JOIN DBO.Staffs ON MOR_FUN_ID = FUN_ID ORDER BY MOR_AP_ID"
                );
            //return View(db.Residents.ToList());
            return View(byapart.ToList());
            //return View();
        }

        public ActionResult Report2()
        {

            return View();
        }

        public ActionResult Report3()
        {
            return View();
        }

        public ActionResult Report4()
        {
            return View();
        }

        //// GET: Reports/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Reports/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Reports/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Reports/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Reports/Edit/5
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

        //// GET: Reports/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Reports/Delete/5
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
    }
    }

