//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EjercicioPracticas1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocVentas
    {
        public int NumeroPedido { get; set; }
        public string EstadoPedido { get; set; }
        public string DescPedido { get; set; }
        public int IdCliente { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
