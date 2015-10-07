using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.ResourceAccess.Dao
{
    internal class VueloDao
    {


        /// <summary>
        /// Seleccionar todos los Vuelos
        /// </summary>
        /// <returns>Lista de Vuelos</returns>
        public IList<Vuelos> SelectAllVuelos()
        {
            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {
                return entities.Vuelos.Include("Cadenas").Include("Ciudades.Departamentos").Include("Ciudades1.Departamentos").ToList();

            }
        }

        /// <summary>
        /// Seleccionar un Vuelo por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un Vuelo</returns>
        public Vuelos SelectVueloById(int id)
        {
            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {


                return entities.Vuelos.SingleOrDefault(p => p.VueloId == id);

                #region otra forma
                //var query = from p in entities.Vuelos
                //            where p.VueloId == id
                //            select p;


                //return query.SingleOrDefault();
                #endregion


            }
        }

        /// <summary>
        /// Inserta un nuevo Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void InsertVuelo(Vuelos vuelo)
        {

            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {
                entities.Vuelos.Add(vuelo);
                entities.SaveChanges();

            }
        }

        /// <summary>
        /// Actualiza un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void UpdateVuelos(Vuelos vuelo)
        {
            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {

                entities.Entry(vuelo).State = EntityState.Modified;
                entities.SaveChanges();


            }

        }

        /// <summary>
        /// ELiminar un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void DeleteVuelo(Vuelos vuelo)
        {

            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {


                //var obj = entities.Vuelos.SingleOrDefault(p => p.VueloId == Vuelo.VueloId);

                //entities.Vuelos.Remove(obj);

                entities.Entry(vuelo).State = EntityState.Deleted;
                entities.SaveChanges();

            }

        }

    }
}

