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
    
    public partial class Cadenas
    {
        public Cadenas()
        {
            this.Agencias = new HashSet<Agencias>();
            this.Hoteles = new HashSet<Hoteles>();
            this.Vuelos = new HashSet<Vuelos>();
        }
    
        public int CadenaId { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
    
        public virtual ICollection<Agencias> Agencias { get; set; }
        public virtual ICollection<Hoteles> Hoteles { get; set; }
        public virtual ICollection<Vuelos> Vuelos { get; set; }
    }
}
