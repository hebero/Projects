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
    
    public partial class tblDETALLEFACT
    {
        public int ID_DETALLE { get; set; }
        public int ID_FACTURA { get; set; }
        public int ID_PRODUCTO { get; set; }
        public int CANTIDAD { get; set; }
    
        public virtual tblFACTURA tblFACTURA { get; set; }
        public virtual tblProducto tblProducto { get; set; }
    }
}
