using System.Collections.Generic;
using System.Data;
using System.Linq;
using Cedesistemas.Model.Business.Entities;

namespace Cedesistemas.Model.ResourceAccess.Dao
{
    internal class ClienteDao
    {


        /// <summary>
        /// Seleccionar todos los clientes
        /// </summary>
        /// <returns>Lista de clientes</returns>
        public IList<Clientes> SelectAllClientes()
        {
            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {
                return entities.Clientes.ToList();

            }
        }

        /// <summary>
        /// Seleccionar un cliente por el id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un cliente</returns>
        public Clientes SelectClienteById(int id)
        {
            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {


                return entities.Clientes.Include("Movimientos.Agencias").SingleOrDefault(p => p.ClienteId == id);

                #region otra forma
                //var query = from p in entities.Clientes
                //            where p.ClienteId == id
                //            select p;


                //return query.SingleOrDefault();
                #endregion


            }
        }

        /// <summary>
        /// Inserta un nuevo cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        public void InsertCliente(Clientes cliente)
        {

            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {
                entities.Clientes.Add(cliente);
                entities.SaveChanges();

            }
        }

        /// <summary>
        /// Actualiza un cliente
        /// </summary>
        /// <param name="cliente">Cliente</param>
        public void UpdateClientes(Clientes cliente)
        {
            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {

                entities.Entry(cliente).State = EntityState.Modified;
                entities.SaveChanges();


            }

        }

        /// <summary>
        /// ELiminar un cliente
        /// </summary>
        /// <param name="cliente">cliente</param>
        public void DeleteCliente(Clientes cliente)
        {

            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {


                //var obj = entities.Clientes.SingleOrDefault(p => p.ClienteId == cliente.ClienteId);

                //entities.Clientes.Remove(obj);

                entities.Entry(cliente).State = EntityState.Deleted;
                entities.SaveChanges();

            }

        }

        public IList<sp_BuscarPersona_Result> BuscarPersonas(string dato)
        {
            using (AgenciaVIajesDbEntities entities = new AgenciaVIajesDbEntities())
            {
                return entities.sp_BuscarPersona(dato).ToList();
            }
        }

    }
}
