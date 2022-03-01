using System;
using System.ComponentModel.DataAnnotations;

namespace EjercicioPracticas1.Models
{
    public class UsuariosMetadata
    {
        [Display(Name = "Nombre")]
        public string Nombre;

        [Display(Name = "Apellidos")]
        public string Apellidos;

        [Display(Name = "Fecha de nacimiento")]
        public string FechaNacimiento;

        [Display(Name = "Genero")]
        public string Genero;

        [Display(Name = "Activo")]
        public string Activo;
    }
    public class DocVentasMetadata
    {
        [Display(Name = "Numero del pedido")]
        public string NumeroPedido;

        [Display(Name = "Estado del pedido")]
        public string EstadoPedido;

        [Display(Name = "Descripcion del pedido")]
        public string DescPedido;

    }
}