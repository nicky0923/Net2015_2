namespace Cedesistemas.Model.Business.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using ResourceAccess.Dao;
    internal class ClienteBl
    {



        /// <summary>
        /// Seleccionar todos los clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public IList<Clientes> SelectAllClientes()
        {
            return new ClienteDao().SelectAllClientes();
        }

        /// <summary>
        /// Seleccionar un cliente por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un cliente</returns>
        public Clientes SelectClienteById(int id)
        {
            // relizamos una validación
            return id > 0 ? new ClienteDao().SelectClienteById(id) : null;
        }


        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        public void InsertCliente(Clientes cliente)
        {
            IList<Clientes> lista = SelectAllClientes();

            if (lista.FirstOrDefault(p => p.Codigo == cliente.Codigo) != null)
            {
                throw new Exception("El cliente ya existe con el código :" + cliente.Codigo);
            }
            new ClienteDao().InsertCliente(cliente);
        }

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="cliente">Cliente</param>
        public void UpdateClientes(Clientes cliente)
        {
            new ClienteDao().UpdateClientes(cliente);
        }

        /// <summary>
        /// ELiminar un cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        public void DeleteCliente(Clientes cliente)
        {
            // validar si el usuario a borrar exite
            // validar si tiene movimientos y sacar un mensaje personalizado

            new ClienteDao().DeleteCliente(cliente);
        }



        public IList<sp_BuscarPersona_Result> BuscarPersonas(string dato)
        {
            return new ClienteDao().BuscarPersonas(dato);
        }
    }
}
