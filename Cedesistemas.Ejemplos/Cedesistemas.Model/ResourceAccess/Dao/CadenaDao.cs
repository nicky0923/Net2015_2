using System;
using System.Collections.Generic;
using System.Linq;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.ResourceAccess.Dao
{
    internal class CadenaDao
    {
        /// <summary>
        ///  Retorna todas las Cadenas
        /// </summary>
        /// <returns></returns>
        public IList<Cadenas> SelectAllCadenas()
        {

            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {
                return entities.Cadenas.ToList();
            }
        }
    }
}
