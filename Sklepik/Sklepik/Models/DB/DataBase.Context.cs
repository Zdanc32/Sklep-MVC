﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SklepKomputerowyEntities : DbContext
    {
        public SklepKomputerowyEntities()
            : base("name=SklepKomputerowyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adresy> Adresy { get; set; }
        public virtual DbSet<Egzemplarze> Egzemplarze { get; set; }
        public virtual DbSet<Faktury> Faktury { get; set; }
        public virtual DbSet<Galeria_zdjęc> Galeria_zdjęc { get; set; }
        public virtual DbSet<Kategorie> Kategorie { get; set; }
        public virtual DbSet<Kategorie_Producenci> Kategorie_Producenci { get; set; }
        public virtual DbSet<Klientt> Klientt { get; set; }
        public virtual DbSet<Pozyjce_Faktury> Pozyjce_Faktury { get; set; }
        public virtual DbSet<Producenci> Producenci { get; set; }
        public virtual DbSet<Produkty> Produkty { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Zamówienia> Zamówienia { get; set; }
        public virtual DbSet<zamówienia_produkty> zamówienia_produkty { get; set; }
    }
}
