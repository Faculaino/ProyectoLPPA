﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Lppa.Data
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class LppaBD : DbContext
{
    public LppaBD()
        : base("name=LppaBD")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Banco> Banco { get; set; }

    public virtual DbSet<Bitacora> Bitacora { get; set; }

    public virtual DbSet<Contrato> Contrato { get; set; }

    public virtual DbSet<Estado> Estado { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual DbSet<Veraz> Veraz { get; set; }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<Tarjeta> Tarjeta { get; set; }

    public virtual DbSet<Solicitud> Solicitud { get; set; }

}

}

