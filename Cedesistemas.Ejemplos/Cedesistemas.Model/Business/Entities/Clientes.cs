//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Clientes
    {
        public Clientes()
        {
            this.Movimientos = new HashSet<Movimientos>();
        }
    
        public int ClienteId { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
    
        public virtual ICollection<Movimientos> Movimientos { get; set; }
    }
}
