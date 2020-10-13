using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen.Models
{
    [Serializable()]
    public class ProductosModels
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public string Pais { get; set; }

        public int idRamo { get; set; }
    }
}