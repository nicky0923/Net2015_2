
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.ResourceAccess.Dao
{
    internal class CiudadDao
    {

        /// <summary>
        ///  Retorna todas las ciudades
        /// </summary>
        /// <returns></returns>
        public IList<Ciudades> SelectAllCiudades()
        {

            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {
                return entities.Ciudades.ToList();
            }
        }
    }
}
