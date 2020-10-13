using Examen.DAO.Ramos;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class RamosController : Controller
    {
        // GET: Ramos
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult buscar(RamosModels RamosModels)
        {
            try
            {
                string Pais = string.Empty;
                if (Session["Pais"] != null)
                {
                    Pais = Session["Pais"].ToString();
                }

                //List<RamosModels> lsRamos = new List<RamosModels>();

                RamosDao ramosDao = new RamosDao();
                var lsRamos = ramosDao.Buscar(RamosModels.id, RamosModels.Descripcion, Pais);

                return Json(lsRamos, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}