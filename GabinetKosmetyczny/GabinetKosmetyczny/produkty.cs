//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GabinetKosmetyczny
{
    using System;
    using System.Collections.Generic;
    
    public partial class produkty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public produkty()
        {
            this.produkty_do_zabiegu = new HashSet<produkty_do_zabiegu>();
        }
    
        public int id_produktu { get; set; }
        public string nazwa { get; set; }
        public decimal cena { get; set; }
        public string producent { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produkty_do_zabiegu> produkty_do_zabiegu { get; set; }
    }
}