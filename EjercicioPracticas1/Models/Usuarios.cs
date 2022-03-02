namespace EjercicioPracticas1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            DocVentas = new HashSet<DocVentas>();
        }

        [Key]
        public int IdCliente { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Apellidos { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Genero { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocVentas> DocVentas { get; set; }
    }
}
