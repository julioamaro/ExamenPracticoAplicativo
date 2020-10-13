using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoberturasFianzas.DAO.Helpers
{
    interface IUsuariosDao
    {
        string VerificarUsuario(string userName, string psw);
    }
}
