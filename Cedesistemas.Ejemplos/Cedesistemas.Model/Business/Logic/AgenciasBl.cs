using System.Collections.Generic;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.ResourceAccess.Dao;

namespace Cedesistemas.Model.Business.Logic
{
    internal class AgenciasBl
    {


        /// <summary>
        /// Returns the list ofAgencias
        /// </summary>
        /// <returns>Listado de Agencias</returns>
        public IList<Agencias> SelectAllAgencias()
        {
            AgenciasDao objAgenciasDao = new AgenciasDao();
            return objAgenciasDao.SelectAllAgencias();
        }

        /// <summary>
        /// Returns Agencias by Id
        /// </summary>
        /// <returns> Agencias</returns>
        public Agencias SelectByIdAgencias(int agenciaid)
        {
            AgenciasDao objAgenciasDao = new AgenciasDao();
            return objAgenciasDao.SelectByIdAgencias(agenciaid);
        }

        /// <summary>
        /// Save   Agencias
        /// </summary>
        /// <param name="objAgencias">Entity  Agencias</param>
        /// <returns>Tercero</returns>
        public void Save(Agencias objAgencias)
        {
            AgenciasDao objAgenciasDao = new AgenciasDao();
            objAgenciasDao.InsertarAgencias(objAgencias);
        }

        /// <summary>
        /// Actualiza un Agencias
        /// </summary>
        /// <param name="objAgencias>">Entity  Agencias</param>
        /// <returns>Agencias</returns>
        public void Update(Agencias objAgencias)
        {
            AgenciasDao objAgenciasDao = new AgenciasDao();
            objAgenciasDao.UpdateAgencias(objAgencias);
        }

        /// <summary>
        /// Delete  Agencias
        /// </summary>
        /// <param name="objAgencias>">Entity  Agencias</param>
        public void Delete(Agencias objAgencias)
        {
            AgenciasDao objAgenciasDao = new AgenciasDao();
            objAgenciasDao.DeleteAgencias(objAgencias);
        }
    }
}

