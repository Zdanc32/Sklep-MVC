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
    
    public partial class Egzemplarze
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Egzemplarze()
        {
            this.Pozyjce_Faktury = new HashSet<Pozyjce_Faktury>();
        }
    
        public int IdEgzemplarzu { get; set; }
        public Nullable<int> IdProduktu { get; set; }
        public string kod_produktu { get; set; }
        public string cena { get; set; }
        public Nullable<System.DateTime> data_sprzedaży { get; set; }
        public Nullable<System.DateTime> data_zakupu { get; set; }
        public string czy_sprzedano { get; set; }
    
        public virtual Produkty Produkty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pozyjce_Faktury> Pozyjce_Faktury { get; set; }
    }
}
