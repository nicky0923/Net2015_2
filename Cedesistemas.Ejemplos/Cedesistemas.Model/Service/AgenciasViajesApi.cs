
using System.Collections.Generic;
using System.ComponentModel;
using Cedesistemas.Model.Business.Entities;
using Cedesistemas.Model.Business.Logic;

namespace Cedesistemas.Model.Service
{
    [DataObject(true)]
    public class AgenciasViajesApi : IAgenciasViajesApi
    {

        #region Clientes
        /// <summary>
        /// Seleccionar todos los clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public IList<Clientes> SelectAllClientes()
        {
            return new ClienteBl().SelectAllClientes();
        }

        /// <summary>
        /// Seleccionar un cliente por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un cliente</returns>
        public Clientes SelectClienteById(int id)
        {
            return new ClienteBl().SelectClienteById(id);
        }


        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        public void InsertCliente(Clientes cliente)
        {
            new ClienteBl().InsertCliente(cliente);
        }

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="cliente">Cliente</param>
        public void UpdateClientes(Clientes cliente)
        {
            new ClienteBl().UpdateClientes(cliente);
        }

        /// <summary>
        /// ELiminar un cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        public void DeleteCliente(Clientes cliente)
        {
            new ClienteBl().DeleteCliente(cliente);
        }

        public IList<sp_BuscarPersona_Result> BuscarPersonas(string dato)
        {
           return new ClienteBl().BuscarPersonas(dato);
        }

        #endregion

        #region Ciudades
        /// <summary>
        ///  Retorna todas las ciudades
        /// </summary>
        /// <returns></returns>
        public IList<Ciudades> SelectAllCiudades()
        {
            return new CiudadBl().SelectAllCiudades();

        }
        #endregion

        #region Cadenas

        public IList<Cadenas> SelectAllCadenas()
        {
            return new CadenaBl().SelectAllCadenas();
        }

        #endregion

        #region Vuelos
        /// <summary>
        /// Seleccionar todos los Vuelos
        /// </summary>
        /// <returns>Lista de Vuelos</returns>
        public IList<Vuelos> SelectAllVuelos()
        {
            return new VueloBl().SelectAllVuelos();
        }

        /// <summary>
        /// Seleccionar un Vuelo por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un Vuelo</returns>
        public Vuelos SelectVueloById(int id)
        {
            return new VueloBl().SelectVueloById(id);
        }

        /// <summary>
        /// Inserta un nuevo Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void InsertVuelo(Vuelos vuelo)
        {
            new VueloBl().InsertVuelo(vuelo);
        }

        /// <summary>
        /// Actualiza un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void UpdateVuelos(Vuelos vuelo)
        {
            new VueloBl().UpdateVuelos(vuelo);
        }

        /// <summary>
        /// ELiminar un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        public void DeleteVuelo(Vuelos vuelo)
        {
            new VueloBl().DeleteVuelo(vuelo);
        }
        #endregion
        #region Agencias
        /// <summary>
        /// Returns the list ofAgencias
        /// </summary>
        /// <returns>Listado de Agencias</returns>
        public IList<Agencias> SelectAllAgencias()
        {
            AgenciasBl objAgenciasBl = new AgenciasBl();
            return objAgenciasBl.SelectAllAgencias();
        }

        /// <summary>
        /// Returns Agencias by Id
        /// </summary>
        /// <returns> Agencias</returns>
        public Agencias SelectAgenciasById(int agenciaid)
        {
            AgenciasBl objAgenciasBl = new AgenciasBl();
            return objAgenciasBl.SelectByIdAgencias(agenciaid);
        }

        /// <summary>
        /// Save   Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        /// <returns>Tercero</returns>
        public void SaveAgencias(Agencias objAgencias)
        {
            AgenciasBl objAgenciasBL = new AgenciasBl();
            objAgenciasBL.Save(objAgencias);
        }

        /// <summary>
        /// Actualiza un Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        /// <returns>Agencias</returns>
        public void UpdateAgencias(Agencias objAgencias)
        {
            AgenciasBl objAgenciasBL = new AgenciasBl();
            objAgenciasBL.Update(objAgencias);
        }

        /// <summary>
        /// Delete  Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        public void DeleteAgencias(Agencias objAgencias)
        {
            AgenciasBl objAgenciasBL = new AgenciasBl();
            objAgenciasBL.Delete(objAgencias);
        }

        #endregion


        #region Servicios
        /// <summary>
        /// Returns the list ofServicios
        /// </summary>
        /// <returns>Listado de Servicios</returns>
        public IList<Servicios> SelectAllServicios()
        {
            ServiciosBl objServiciosBl = new ServiciosBl();
            return objServiciosBl.SelectAllServicios();
        }

        /// <summary>
        /// Returns Servicios by Id
        /// </summary>
        /// <returns> Servicios</returns>
        public Servicios SelectServiciosById(int servicioid)
        {
            ServiciosBl objServiciosBl = new ServiciosBl();
            return objServiciosBl.SelectByIdServicios(servicioid);
        }

        /// <summary>
        /// Save   Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        /// <returns>Tercero</returns>
        public void SaveServicios(Servicios objServicios)
        {
            ServiciosBl objServiciosBl = new ServiciosBl();
            objServiciosBl.Save(objServicios);
        }

        /// <summary>
        /// Actualiza un Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        /// <returns>Servicios</returns>
        public void UpdateServicios(Servicios objServicios)
        {
            ServiciosBl objServiciosBl = new ServiciosBl();
            objServiciosBl.Update(objServicios);
        }

        /// <summary>
        /// Delete  Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        public void DeleteServicios(Servicios objServicios)
        {
            ServiciosBl objServiciosBl = new ServiciosBl();
            objServiciosBl.Delete(objServicios);
        }

        #endregion

        #region Hoteles
        /// <summary>
        /// Returns the list ofHoteles
        /// </summary>
        /// <returns>Listado de Hoteles</returns>
        public IList<Hoteles> SelectAllHoteles()
        {
            HotelesBl objHotelesBl = new HotelesBl();
            return objHotelesBl.SelectAllHoteles();
        }

        /// <summary>
        /// Returns Hoteles by Id
        /// </summary>
        /// <returns> Hoteles</returns>
        public Hoteles SelectHotelesById(int hotelid)
        {
            HotelesBl objHotelesBl = new HotelesBl();
            return objHotelesBl.SelectByIdHoteles(hotelid);
        }

        /// <summary>
        /// Save   Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        /// <returns>Tercero</returns>
        public void SaveHoteles(Hoteles objHoteles)
        {
            HotelesBl objHotelesBl = new HotelesBl();
            objHotelesBl.Save(objHoteles);
        }

        /// <summary>
        /// Actualiza un Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        /// <returns>Hoteles</returns>
        public void UpdateHoteles(Hoteles objHoteles)
        {
            HotelesBl objHotelesBl = new HotelesBl();
            objHotelesBl.Update(objHoteles);
        }

        /// <summary>
        /// Delete  Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        public void DeleteHoteles(Hoteles objHoteles)
        {
            HotelesBl objHotelesBl = new HotelesBl();
            objHotelesBl.Delete(objHoteles);
        }

        #endregion
    }
}
