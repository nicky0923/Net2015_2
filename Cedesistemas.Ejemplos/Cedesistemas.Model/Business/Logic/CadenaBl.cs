
namespace Cedesistemas.Model.Business.Logic
{
    using System.Collections.Generic;
    using Entities;
    using ResourceAccess.Dao;

    internal class CadenaBl
    {
        /// <summary>
        ///  Retorna todas las Cadenas
        /// </summary>
        /// <returns></returns>
        public IList<Cadenas> SelectAllCadenas()
        {

            return new CadenaDao().SelectAllCadenas();
        }
    }
}
