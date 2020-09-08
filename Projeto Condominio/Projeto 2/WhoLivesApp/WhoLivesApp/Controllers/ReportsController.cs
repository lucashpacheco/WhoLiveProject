using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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
                "select MOR_ID ,MOR_NOME , MOR_SOBRENOME  , AP_NUMERO , FUN_NOME  from dbo.Residents INNER JOIN dbo.Apartaments ON AP_ID = MOR_AP_ID INNER JOIN DBO.Staffs ON MOR_FUN_ID = FUN_ID ORDER BY MOR_AP_ID"

                );

            return View(byapart.ToList());

        }

        public ActionResult Report2()
        {
            var morapart = db.Database.SqlQuery<Report2>(
                "SELECT AP_NUMERO As Apartamento, COUNT(AP_ID) AS Moradores FROM dbo.Residents INNER JOIN dbo.Apartaments ON MOR_AP_ID = AP_ID GROUP BY AP_NUMERO"

                );

            return View(morapart.ToList());
        }

        public ActionResult Report3()
        {
            var vehapart = db.Database.SqlQuery<Report3>(

                "SELECT AP_NUMERO As Apartamento, COUNT(VEI_ID) AS Veiculos FROM dbo.Apartaments INNER JOIN dbo.Vehicles ON VEI_AP_ID = AP_ID GROUP BY AP_NUMERO"

                );

            return View(vehapart.ToList());
        }

        public ActionResult Report4()
        {
            var att = db.Database.SqlQuery<Report4>(

                "SELECT AP_ID, AP_NUMERO as [Apartamento] , CASE WHEN AP_ATENCAO = 1 THEN 'SIM' WHEN AP_ATENCAO = 0 THEN 'NÃO' END AS[PCD]FROM dbo.Apartaments"

                );

            return View(att.ToList());
        }

    }
}