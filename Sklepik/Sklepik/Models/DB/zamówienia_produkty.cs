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
    
    public partial class zamówienia_produkty
    {
        public int id_zam_prod { get; set; }
        public Nullable<int> id_prod { get; set; }
        public Nullable<int> id_zam { get; set; }
    
        public virtual Produkty Produkty { get; set; }
        public virtual Zamówienia Zamówienia { get; set; }
    }
}
