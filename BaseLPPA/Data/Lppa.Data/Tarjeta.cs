
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
    using System.Collections.Generic;
    
public partial class Tarjeta
{

    public int ID { get; set; }

    public int IDBanco { get; set; }

    public int IDCliente { get; set; }

    public string Marca { get; set; }

    public System.DateTime FechaEmision { get; set; }

    public int FechaVencimiento { get; set; }

    public int CodVerificacion { get; set; }

    public int Limite { get; set; }

    public int CodEstado { get; set; }

    public string CreatedBy { get; set; }

    public System.DateTime CreatedOn { get; set; }

    public string ChangedBy { get; set; }

    public System.DateTime ChangedOn { get; set; }

}

}
