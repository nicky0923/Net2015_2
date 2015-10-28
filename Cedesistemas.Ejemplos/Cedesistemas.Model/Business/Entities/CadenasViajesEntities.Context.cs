﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cedesistemas.Model.Business.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    internal partial class AgenciaVIajesDbEntities : DbContext
    {
        public AgenciaVIajesDbEntities()
            : base("name=AgenciaVIajesDbEntities")
        {
    	Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Agencias> Agencias { get; set; }
        public DbSet<Cadenas> Cadenas { get; set; }
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Hoteles> Hoteles { get; set; }
        public DbSet<Movimientos> Movimientos { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Vuelos> Vuelos { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
    
        public virtual ObjectResult<sp_BuscarPersona_Result> sp_BuscarPersona(string dato)
        {
            var datoParameter = dato != null ?
                new ObjectParameter("dato", dato) :
                new ObjectParameter("dato", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_BuscarPersona_Result>("sp_BuscarPersona", datoParameter);
        }
    }
}
