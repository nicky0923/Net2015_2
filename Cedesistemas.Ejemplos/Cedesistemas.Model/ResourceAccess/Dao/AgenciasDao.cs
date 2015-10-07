using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.ResourceAccess.Dao
{

    internal  class AgenciasDao
    {
        /// <summary>
        /// Returns the list of Agencias
        /// </summary>
        /// <returns>Listado de Agencias</returns>
        public IList<Agencias> SelectAllAgencias()
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                var query = from p in objEntities.Agencias
                            select p;
                return query.ToList();
            }
        }

        /// <summary>
        /// Returns Agencias por la llave primarioa
        /// </summary>
        /// <returns>Agencias</returns>
        public Agencias SelectByIdAgencias(int agenciaid)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                Agencias objAgencias = objEntities.Agencias.Single(p => p.AgenciaId == agenciaid);
                return objAgencias;
            }
        }

        /// <summary>
        /// Save  Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        /// <returns>Agencias</returns>
        public void InsertarAgencias(Agencias objAgencias)
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                objEntities.Agencias.Add(objAgencias);
                objEntities.SaveChanges();                
            }
        }

        /// <summary>
        /// Actualiza un Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        /// <returns>Agencias</returns>
        public void UpdateAgencias(Agencias  objAgencias )
        {
            using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {                
				objEntities.Entry(objAgencias).State = EntityState.Modified;
				objEntities.SaveChanges();    
               
            }
        }
		
		/// <summary>
        /// Delete  Agencias
        /// </summary>
        /// <param name="objAgencias">EntityAgencias</param>        
        public void DeleteAgencias(Agencias objAgencias)
        {
             using (AgenciaVIajesDbEntities objEntities = new AgenciaVIajesDbEntities())
            {
                var obj = objEntities.Agencias.Single(p => p.AgenciaId == objAgencias.AgenciaId);
				objEntities.Agencias.Remove(obj);
                objEntities.SaveChanges();
            }
        }
    }
}
 
 