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
    
    public partial class Departamentos
    {
        public Departamentos()
        {
            this.Ciudades = new HashSet<Ciudades>();
        }
    
        public int DepartamentoId { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Ciudades> Ciudades { get; set; }
    }
}
