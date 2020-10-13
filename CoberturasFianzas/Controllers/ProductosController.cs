using Examen.DAO.Productos;
using Examen.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CoberturasFianzas.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Buscar(ProductosModels productosModels)
        {
            try
            {
                string Pais = Session["Pais"].ToString();

                ProductosDao productosDao = new ProductosDao();
                var Producto = (productosDao.Buscar(productosModels.id, productosModels.Descripcion, Pais, productosModels.idRamo));
                
                return Json(Producto, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}