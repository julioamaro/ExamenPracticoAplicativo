using Examen.DAO.Usuarios;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace CoberturasFianzas.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            return View();
        }

        public int Acceso(UsariosModels UsariosModels)
        {
           return VerificarUsuario(UsariosModels.UserName, UsariosModels.Pws);
        }

        public int VerificarUsuario(string userName, string psw)
        {
            try
            {
                int existeUsuario = 0;
                string result = string.Empty;

                UsuariosDao usuariosDao = new UsuariosDao();
                result= usuariosDao.VerificarUsuario(userName, psw);

                if (result != null && result!="")
                {
                       existeUsuario = 1;
                       Session["Pais"] = result;
                }

                return existeUsuario;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }

}