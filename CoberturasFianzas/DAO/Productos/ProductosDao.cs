using CoberturasFianzas.ServiceReference1;
using Examen.DAO.Helpers;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Xml.Linq;

namespace Examen.DAO.Productos
{
    public class ProductosDao : IProductosDao
    {
        public List<Models.ProductosModels> Buscar(int id, string Descripcion, string Pais, int idRamos)
        {
            ServiceExamenClient serviceExamenClient = new ServiceExamenClient();
            try
            {
                var result = serviceExamenClient.BuscarProductos(id, Descripcion, Pais, idRamos).ToList();

                var consulta = (from p in result
                                select new Examen.Models.ProductosModels()
                                {
                                    Descripcion = p.Descripcion,
                                    id = p.id,
                                    Pais = p.Pais,
                                    idRamo = p.idRamo
                                }).ToList();

                return consulta;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
 }
