using System.Collections.Generic;
using System.ServiceModel;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.Service
{
    [ServiceContract]
    public interface IAgenciasViajesApi
    {
        /// <summary>
        /// Seleccionar todos los clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        [OperationContract]
        IList<Clientes> SelectAllClientes();

        /// <summary>
        /// Seleccionar un cliente por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un cliente</returns>
        [OperationContract]
        Clientes SelectClienteById(int id);

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        void InsertCliente(Clientes cliente);

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="cliente">Cliente</param>
        void UpdateClientes(Clientes cliente);

        /// <summary>
        /// ELiminar un cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        void DeleteCliente(Clientes cliente);

        IList<sp_BuscarPersona_Result> BuscarPersonas(string dato);

        /// <summary>
        ///  Retorna todas las ciudades
        /// </summary>
        /// <returns></returns>
        IList<Ciudades> SelectAllCiudades();

        IList<Cadenas> SelectAllCadenas();

        /// <summary>
        /// Seleccionar todos los Vuelos
        /// </summary>
        /// <returns>Lista de Vuelos</returns>
        IList<Vuelos> SelectAllVuelos();

        /// <summary>
        /// Seleccionar un Vuelo por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un Vuelo</returns>
        Vuelos SelectVueloById(int id);

        /// <summary>
        /// Inserta un nuevo Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        void InsertVuelo(Vuelos vuelo);

        /// <summary>
        /// Actualiza un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        void UpdateVuelos(Vuelos vuelo);

        /// <summary>
        /// ELiminar un Vuelo
        /// </summary>
        /// <param name="vuelo">Vuelo</param>
        void DeleteVuelo(Vuelos vuelo);

        /// <summary>
        /// Returns the list ofAgencias
        /// </summary>
        /// <returns>Listado de Agencias</returns>
        IList<Agencias> SelectAllAgencias();

        /// <summary>
        /// Returns Agencias by Id
        /// </summary>
        /// <returns> Agencias</returns>
        Agencias SelectAgenciasById(int agenciaid);

        /// <summary>
        /// Save   Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        /// <returns>Tercero</returns>
        void SaveAgencias(Agencias objAgencias);

        /// <summary>
        /// Actualiza un Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        /// <returns>Agencias</returns>
        void UpdateAgencias(Agencias objAgencias);

        /// <summary>
        /// Delete  Agencias
        /// </summary>
        /// <param name="objAgencias">Entity Agencias</param>
        void DeleteAgencias(Agencias objAgencias);

        /// <summary>
        /// Returns the list ofServicios
        /// </summary>
        /// <returns>Listado de Servicios</returns>
        IList<Servicios> SelectAllServicios();

        /// <summary>
        /// Returns Servicios by Id
        /// </summary>
        /// <returns> Servicios</returns>
        Servicios SelectServiciosById(int servicioid);

        /// <summary>
        /// Save   Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        /// <returns>Tercero</returns>
        void SaveServicios(Servicios objServicios);

        /// <summary>
        /// Actualiza un Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        /// <returns>Servicios</returns>
        void UpdateServicios(Servicios objServicios);

        /// <summary>
        /// Delete  Servicios
        /// </summary>
        /// <param name="objServicios">Entity Servicios</param>
        void DeleteServicios(Servicios objServicios);

        /// <summary>
        /// Returns the list ofHoteles
        /// </summary>
        /// <returns>Listado de Hoteles</returns>
        IList<Hoteles> SelectAllHoteles();

        /// <summary>
        /// Returns Hoteles by Id
        /// </summary>
        /// <returns> Hoteles</returns>
        Hoteles SelectHotelesById(int hotelid);

        /// <summary>
        /// Save   Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        /// <returns>Tercero</returns>
        void SaveHoteles(Hoteles objHoteles);

        /// <summary>
        /// Actualiza un Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        /// <returns>Hoteles</returns>
        void UpdateHoteles(Hoteles objHoteles);

        /// <summary>
        /// Delete  Hoteles
        /// </summary>
        /// <param name="objHoteles">Entity Hoteles</param>
        void DeleteHoteles(Hoteles objHoteles);
    }
}