//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConexionTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblDETALLEMOV
    {
        public int ID_DETALLEMOV { get; set; }
        public int ID_MOVIMIENTO { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
        public System.DateTime FECHAVENCIMIENTO { get; set; }
    
        public virtual tblMovimiento tblMovimiento { get; set; }
        public virtual tblProducto tblProducto { get; set; }
    }
}
