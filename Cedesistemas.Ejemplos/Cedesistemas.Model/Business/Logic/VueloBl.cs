
namespace Cedesistemas.Model.Business.Logic
{
    using System.Collections.Generic;
    using Entities;
    using ResourceAccess.Dao;

    internal class VueloBl
    {

        /// <summary>
        /// Seleccionar todos los Vuelos
        /// </summary>
        /// <returns>Lista de Vuelos</returns>
        public IList<Vuelos> SelectAllVuelos()
        {
            return new VueloDao().SelectAllVuelos();
        }

        /// <summary>
        /// Seleccionar un Vuelo por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un Vuelo</returns>
        public Vuelos SelectVueloById(int id)
        {
            return new VueloDao().SelectVueloById(id);
        }

        /// <summary>
        /// Inserta un nuevo Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void InsertVuelo(Vuelos vuelo)
        {
            new VueloDao().InsertVuelo(vuelo);
        }

        /// <summary>
        /// Actualiza un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void UpdateVuelos(Vuelos vuelo)
        {
            new VueloDao().UpdateVuelos(vuelo);
        }

        /// <summary>
        /// ELiminar un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void DeleteVuelo(Vuelos vuelo)
        {
            new VueloDao().DeleteVuelo(vuelo);
        }
    }
}
