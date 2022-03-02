namespace EjercicioPracticas1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocVentas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroPedido { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string EstadoPedido { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DescPedido { get; set; }

        public int IdCliente { get; set; }

        public virtual Usuarios Usuarios { get; set; }
    }
}
