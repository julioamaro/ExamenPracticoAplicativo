using CoberturasFianzas.ServiceReference1;
using Examen.DAO.Helpers;
using Examen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;
using RamosModels = Examen.Models.RamosModels;

namespace Examen.DAO.Ramos
{
    public class RamosDao : IRamosDao
    {
       
       public  List<RamosModels> Buscar(int id, string Descripcion, string Pais)
        {
            try
            {
               ServiceExamenClient serviceExamenClient = new ServiceExamenClient();
                try
                {
                   var result = serviceExamenClient.BuscarRamos(id, Descripcion, Pais).ToList();

                    var consulta = (from p in result
                                    select new RamosModels()
                                    {
                                        Descripcion = p.Descripcion,
                                        id = p.id,
                                        Pais = p.Pais
                                    }).ToList();

                   return consulta;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}