//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sklepik.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producenci()
        {
            this.Kategorie_Producenci = new HashSet<Kategorie_Producenci>();
        }
    
        public int Id_producenta { get; set; }
        public string Nazwa_producenta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kategorie_Producenci> Kategorie_Producenci { get; set; }
    }
}
