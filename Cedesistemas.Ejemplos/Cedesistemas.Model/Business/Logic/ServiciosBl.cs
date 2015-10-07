using System.Collections.Generic;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.ResourceAccess.Dao;

namespace Cedesistemas.Model.Business.Logic
{
    internal class ServiciosBl
    {
        /// <summary>
        /// Returns the list ofServicios
        /// </summary>
        /// <returns>Listado de Servicios</returns>
        public IList<Servicios> SelectAllServicios()
        {
            ServiciosDao objServiciosDao = new ServiciosDao();
            return objServiciosDao.SelectAllServicios();
        }

        /// <summary>
        /// Returns Servicios by Id
        /// </summary>
        /// <returns> Servicios</returns>
        public Servicios SelectByIdServicios(int servicioid)
        {
            ServiciosDao objServiciosDao = new ServiciosDao();
            return objServiciosDao.SelectByIdServicios(servicioid);
        }

        /// <summary>
        /// Save   Servicios
        /// </summary>
        /// <param name="objServicios">Entity  Servicios</param>
        /// <returns>Tercero</returns>
        public void Save(Servicios objServicios)
        {
            ServiciosDao objServiciosDao = new ServiciosDao();
            objServiciosDao.InsertarServicios(objServicios);
        }

        /// <summary>
        /// Actualiza un Servicios
        /// </summary>
        /// <param name="objServicios>">Entity  Servicios</param>
        /// <returns>Servicios</returns>
        public void Update(Servicios objServicios)
        {
            ServiciosDao objServiciosDao = new ServiciosDao();
            objServiciosDao.UpdateServicios(objServicios);
        }

        /// <summary>
        /// Delete  Servicios
        /// </summary>
        /// <param name="objServicios>">Entity  Servicios</param>
        public void Delete(Servicios objServicios)
        {
            ServiciosDao objServiciosDao = new ServiciosDao();
            objServiciosDao.DeleteServicios(objServicios);
        }
    }
}

