using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.ResourceAccess.Dao;

namespace Cedesistemas.Model.Business.Logic
{
   internal class CiudadBl
    {

        /// <summary>
        ///  Retorna todas las ciudades
        /// </summary>
        /// <returns></returns>
        public IList<Ciudades> SelectAllCiudades()
        {
            return  new CiudadDao().SelectAllCiudades();
           
        }
    }
}
