using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.DAO.Helpers
{
    public interface IProductosDao
    {
        List<ProductosModels> Buscar(int id, string Descripcion, string Pais, int idRamos);
    }
}
