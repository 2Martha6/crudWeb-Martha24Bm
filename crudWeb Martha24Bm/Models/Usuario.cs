using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace crudWeb_Martha24Bm.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo  es obligatorio. ")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Este campo  es obligatorio.")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "Este campo  es obligatorio. ")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Telefono { get; set; }

        public string? Correo { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]

        public string? PaginaWeb { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Encabezado { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Texto{ get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? EncabezadoW { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? TextoW { get; set; }

        public int? html { get; set; }
        public int? css { get; set; }
        public int? js { get; set; }
        public int? wp { get; set; }
        public int? photo { get; set; }
        public int? php { get; set; }
        public int? linux { get; set; }
        public int? seo { get; set; }


    }


}

