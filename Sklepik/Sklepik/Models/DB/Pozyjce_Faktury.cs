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
    
    public partial class Pozyjce_Faktury
    {
        public int Id_pozycji { get; set; }
        public Nullable<int> Id_egzemplarzu { get; set; }
        public Nullable<int> Id_faktury { get; set; }
        public string cena { get; set; }
    
        public virtual Egzemplarze Egzemplarze { get; set; }
        public virtual Faktury Faktury { get; set; }
    }
}
