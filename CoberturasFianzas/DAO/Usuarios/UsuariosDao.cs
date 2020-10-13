using CoberturasFianzas.DAO.Helpers;
using CoberturasFianzas.ServiceReference1;
using Examen.DAO.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.DAO.Usuarios
{
    public class UsuariosDao : IUsuariosDao
    {
        public string VerificarUsuario(string userName, string psw)
        {
            ServiceExamenClient serviceExamenClient = new ServiceExamenClient();
            try
            {
                string result = serviceExamenClient.VerificarUsuario(userName, psw);

                return result;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}