using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.ResourceAccess.Dao
{

    internal class HotelesDao
    {


        /// <summary>
        /// Returns the list of Hoteles
        /// </summary>
        /// <returns>Listado de Hoteles</returns>
        public IList<Hoteles> SelectAllHoteles()
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                var query = from p in objEntities.Hoteles
                            select p;
                return query.ToList();
            }
        }

        /// <summary>
        /// Returns Hoteles por la llave primarioa
        /// </summary>
        /// <returns>Hoteles</returns>
        public Hoteles SelectByIdHoteles(int hotelid)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                Hoteles objHoteles = objEntities.Hoteles.Single(p => p.HotelId == hotelid);
                return objHoteles;
            }
        }

        /// <summary>
        /// Save  Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        /// <returns>Hoteles</returns>
        public void InsertarHoteles(Hoteles objHoteles)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                objEntities.Hoteles.Add(objHoteles);
                objEntities.SaveChanges();
            }
        }

        /// <summary>
        /// Actualiza un Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        /// <returns>Hoteles</returns>
        public void UpdateHoteles(Hoteles objHoteles)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                objEntities.Entry(objHoteles).State = EntityState.Modified;
                objEntities.SaveChanges();

            }
        }

        /// <summary>
        /// Delete  Hoteles
        /// </summary>
        /// <param name="objHoteles">EntityHoteles</param>        
        public void DeleteHoteles(Hoteles objHoteles)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                var obj = objEntities.Hoteles.Single(p => p.HotelId == objHoteles.HotelId);
                objEntities.Hoteles.Remove(obj);
                objEntities.SaveChanges();
            }
        }
    }
}

