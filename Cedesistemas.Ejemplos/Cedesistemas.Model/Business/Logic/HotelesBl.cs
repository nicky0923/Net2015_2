using System.Collections.Generic;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.ResourceAccess.Dao;

namespace Cedesistemas.Model.Business.Logic
{
    public class HotelesBl
    {

        public HotelesBl()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// Returns the list ofHoteles
        /// </summary>
        /// <returns>Listado de Hoteles</returns>
        public IList<Hoteles> SelectAllHoteles()
        {
            HotelesDao objHotelesDao = new HotelesDao();
            return objHotelesDao.SelectAllHoteles();
        }

        /// <summary>
        /// Returns Hoteles by Id
        /// </summary>
        /// <returns> Hoteles</returns>
        public Hoteles SelectByIdHoteles(int hotelid)
        {
            HotelesDao objHotelesDao = new HotelesDao();
            return objHotelesDao.SelectByIdHoteles(hotelid);
        }

        /// <summary>
        /// Save   Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity  Hoteles</param>
        /// <returns>Tercero</returns>
        public void Save(Hoteles objHoteles)
        {
            HotelesDao objHotelesDao = new HotelesDao();
            objHotelesDao.InsertarHoteles(objHoteles);
        }

        /// <summary>
        /// Actualiza un Hoteles
        /// </summary>
        /// <param name="objHoteles>">Entity  Hoteles</param>
        /// <returns>Hoteles</returns>
        public void Update(Hoteles objHoteles)
        {
            HotelesDao objHotelesDao = new HotelesDao();
            objHotelesDao.UpdateHoteles(objHoteles);
        }

        /// <summary>
        /// Delete  Hoteles
        /// </summary>
        /// <param name="objHoteles>">Entity  Hoteles</param>
        public void Delete(Hoteles objHoteles)
        {
            HotelesDao objHotelesDao = new HotelesDao();
            objHotelesDao.DeleteHoteles(objHoteles);
        }
    }
}

