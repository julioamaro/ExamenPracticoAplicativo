using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.DAO.Helpers
{
    public interface IRamosDao
    {
        List<RamosModels> Buscar(int clave, string Descripcion, string Pais);
    }
}