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
    
    public partial class Adresy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Adresy()
        {
            this.Klientt = new HashSet<Klientt>();
        }
    
        public int IdAdres { get; set; }
        public string miasto { get; set; }
        public string miejscowość { get; set; }
        public string nr_domu { get; set; }
        public string kod_pocztowy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klientt> Klientt { get; set; }
    }
}
