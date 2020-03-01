﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoznaniciWEBAPP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Poznanici1Entities : DbContext
    {
        public Poznanici1Entities()
            : base("name=Poznanici1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Osoba> Osobas { get; set; }
        public virtual DbSet<PunoletniSmederevci> PunoletniSmederevcis { get; set; }
    
        [DbFunction("Poznanici1Entities", "fnMaxVisina")]
        public virtual IQueryable<fnMaxVisina_Result> fnMaxVisina()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnMaxVisina_Result>("[Poznanici1Entities].[fnMaxVisina]()");
        }
    
        [DbFunction("Poznanici1Entities", "fnSrednjaStarost")]
        public virtual IQueryable<fnSrednjaStarost_Result> fnSrednjaStarost()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fnSrednjaStarost_Result>("[Poznanici1Entities].[fnSrednjaStarost]()");
        }
    
        public virtual int delOSOBA(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("delOSOBA", idParameter);
        }
    
        public virtual int insOSOBA(string jMBG, string ime, string prezime, Nullable<short> visina, Nullable<short> tezina, string bojaOciju, string telefon, string eposta, Nullable<System.DateTime> rodjendan, string adresa, string prebivaliste)
        {
            var jMBGParameter = jMBG != null ?
                new ObjectParameter("JMBG", jMBG) :
                new ObjectParameter("JMBG", typeof(string));
    
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var visinaParameter = visina.HasValue ?
                new ObjectParameter("Visina", visina) :
                new ObjectParameter("Visina", typeof(short));
    
            var tezinaParameter = tezina.HasValue ?
                new ObjectParameter("Tezina", tezina) :
                new ObjectParameter("Tezina", typeof(short));
    
            var bojaOcijuParameter = bojaOciju != null ?
                new ObjectParameter("BojaOciju", bojaOciju) :
                new ObjectParameter("BojaOciju", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var epostaParameter = eposta != null ?
                new ObjectParameter("Eposta", eposta) :
                new ObjectParameter("Eposta", typeof(string));
    
            var rodjendanParameter = rodjendan.HasValue ?
                new ObjectParameter("Rodjendan", rodjendan) :
                new ObjectParameter("Rodjendan", typeof(System.DateTime));
    
            var adresaParameter = adresa != null ?
                new ObjectParameter("Adresa", adresa) :
                new ObjectParameter("Adresa", typeof(string));
    
            var prebivalisteParameter = prebivaliste != null ?
                new ObjectParameter("Prebivaliste", prebivaliste) :
                new ObjectParameter("Prebivaliste", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insOSOBA", jMBGParameter, imeParameter, prezimeParameter, visinaParameter, tezinaParameter, bojaOcijuParameter, telefonParameter, epostaParameter, rodjendanParameter, adresaParameter, prebivalisteParameter);
        }
    
        public virtual ObjectResult<selOSOBA_Result> selOSOBA(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<selOSOBA_Result>("selOSOBA", idParameter);
        }
    
        public virtual int updOSOBA(Nullable<int> id, string jMBG, string ime, string prezime, Nullable<short> visina, Nullable<short> tezina, string bojaOciju, string telefon, string eposta, Nullable<System.DateTime> rodjendan, string adresa, string prebivaliste)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var jMBGParameter = jMBG != null ?
                new ObjectParameter("JMBG", jMBG) :
                new ObjectParameter("JMBG", typeof(string));
    
            var imeParameter = ime != null ?
                new ObjectParameter("Ime", ime) :
                new ObjectParameter("Ime", typeof(string));
    
            var prezimeParameter = prezime != null ?
                new ObjectParameter("Prezime", prezime) :
                new ObjectParameter("Prezime", typeof(string));
    
            var visinaParameter = visina.HasValue ?
                new ObjectParameter("Visina", visina) :
                new ObjectParameter("Visina", typeof(short));
    
            var tezinaParameter = tezina.HasValue ?
                new ObjectParameter("Tezina", tezina) :
                new ObjectParameter("Tezina", typeof(short));
    
            var bojaOcijuParameter = bojaOciju != null ?
                new ObjectParameter("BojaOciju", bojaOciju) :
                new ObjectParameter("BojaOciju", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var epostaParameter = eposta != null ?
                new ObjectParameter("Eposta", eposta) :
                new ObjectParameter("Eposta", typeof(string));
    
            var rodjendanParameter = rodjendan.HasValue ?
                new ObjectParameter("Rodjendan", rodjendan) :
                new ObjectParameter("Rodjendan", typeof(System.DateTime));
    
            var adresaParameter = adresa != null ?
                new ObjectParameter("Adresa", adresa) :
                new ObjectParameter("Adresa", typeof(string));
    
            var prebivalisteParameter = prebivaliste != null ?
                new ObjectParameter("Prebivaliste", prebivaliste) :
                new ObjectParameter("Prebivaliste", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("updOSOBA", idParameter, jMBGParameter, imeParameter, prezimeParameter, visinaParameter, tezinaParameter, bojaOcijuParameter, telefonParameter, epostaParameter, rodjendanParameter, adresaParameter, prebivalisteParameter);
        }
    }
}