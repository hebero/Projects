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
    
    public partial class tblBodega
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBodega()
        {
            this.tblFACTURA = new HashSet<tblFACTURA>();
            this.tblInventario = new HashSet<tblInventario>();
            this.tblMovimiento = new HashSet<tblMovimiento>();
        }
    
        public int ID_BODEGA { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public int MAX_CAP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFACTURA> tblFACTURA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInventario> tblInventario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMovimiento> tblMovimiento { get; set; }
    }
}
