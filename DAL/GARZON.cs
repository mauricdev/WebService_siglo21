//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class GARZON
    {
        public GARZON()
        {
            this.PEDIDO = new HashSet<PEDIDO>();
        }
    
        public string RUT_GARZON { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string CORREO { get; set; }
        public string CONTRASENA { get; set; }
    
        public virtual ICollection<PEDIDO> PEDIDO { get; set; }
    }
}
