
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
    
public partial class Solicitud
{

    public int ID { get; set; }

    public int IDCliente { get; set; }

    public int IDTarjeta { get; set; }

    public int CodEstado { get; set; }

    public byte[] FotoCliente { get; set; }

    public byte[] FirmaCliente { get; set; }

    public string Email { get; set; }

    public string Celular { get; set; }

    public string CreatedBy { get; set; }

    public System.DateTime CreatedOn { get; set; }

    public string ChangedBy { get; set; }

    public System.DateTime ChangedOn { get; set; }

}

}
