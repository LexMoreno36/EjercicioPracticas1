using System;
using System.ComponentModel.DataAnnotations;

namespace EjercicioPracticas1.Models
{
    [MetadataType(typeof(UsuariosMetadata))]
    public partial class Usuarios
    {
    }

    [MetadataType(typeof(DocVentasMetadata))]
    public partial class DocVentas
    {
    }
}