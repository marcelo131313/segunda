//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbvotousuario
    {
        public int idvotousuario { get; set; }
        public int idlugar { get; set; }
        public Nullable<long> iduser { get; set; }
        public Nullable<sbyte> scor { get; set; }
        public System.DateTime fechacreacion { get; set; }
        public System.DateTime fechamodificacion { get; set; }
        public Nullable<int> estado { get; set; }
    
        public virtual tblugares tblugares { get; set; }
        public virtual tbusuario tbusuario { get; set; }
    }
}
