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
    
    public partial class DIRECCION
    {
        public DIRECCION()
        {
            this.PROVEEDOR = new HashSet<PROVEEDOR>();
            this.SUCURSAL = new HashSet<SUCURSAL>();
        }
    
        public int ID_DIRECCION { get; set; }
        public string NOMBRECALLE { get; set; }
        public short NUMEROCALLE { get; set; }
        public int ID_CIUDAD { get; set; }
        public string ESTADO { get; set; }
    
        public virtual CIUDAD CIUDAD { get; set; }
        public virtual ICollection<PROVEEDOR> PROVEEDOR { get; set; }
        public virtual ICollection<SUCURSAL> SUCURSAL { get; set; }
    }
}
