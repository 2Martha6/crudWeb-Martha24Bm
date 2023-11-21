using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace crudWeb_Martha24Bm.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El campo Título es obligatorio.")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "El campo Descripcion es obligatorio.")]
        public string? Descripcion { get; set; }
    }
}
