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
    
    public partial class CAJA
    {
        public CAJA()
        {
            this.CUADRATURA = new HashSet<CUADRATURA>();
            this.MOVIMIENTOCAJA = new HashSet<MOVIMIENTOCAJA>();
        }
    
        public short ID_CAJA { get; set; }
        public string ESTADO { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<CUADRATURA> CUADRATURA { get; set; }
        public virtual ICollection<MOVIMIENTOCAJA> MOVIMIENTOCAJA { get; set; }
    }
}
