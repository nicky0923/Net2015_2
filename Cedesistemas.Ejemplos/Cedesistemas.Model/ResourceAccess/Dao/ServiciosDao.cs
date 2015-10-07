using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.ResourceAccess.Dao
{

    internal class ServiciosDao
    {
       
        /// <summary>
        /// Returns the list of Servicios
        /// </summary>
        /// <returns>Listado de Servicios</returns>
        public IList<Servicios> SelectAllServicios()
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                var query = from p in objEntities.Servicios
                            select p;
                return query.ToList();
            }
        }

        /// <summary>
        /// Returns Servicios por la llave primarioa
        /// </summary>
        /// <returns>Servicios</returns>
        public Servicios SelectByIdServicios(int servicioid)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                Servicios objServicios = objEntities.Servicios.Single(p => p.ServicioId == servicioid);
                return objServicios;
            }
        }

        /// <summary>
        /// Save  Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        /// <returns>Servicios</returns>
        public void InsertarServicios(Servicios objServicios)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                objEntities.Servicios.Add(objServicios);
                objEntities.SaveChanges();
            }
        }

        /// <summary>
        /// Actualiza un Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        /// <returns>Servicios</returns>
        public void UpdateServicios(Servicios objServicios)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                objEntities.Entry(objServicios).State = EntityState.Modified;
                objEntities.SaveChanges();

            }
        }

        /// <summary>
        /// Delete  Servicios
        /// </summary>
        /// <param name="objServicios">EntityServicios</param>        
        public void DeleteServicios(Servicios objServicios)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                var obj = objEntities.Servicios.Single(p => p.ServicioId == objServicios.ServicioId);
                objEntities.Servicios.Remove(obj);
                objEntities.SaveChanges();
            }
        }
    }
}

