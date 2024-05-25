using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using PCT3.Integration;

namespace PCT3.Models
{

    [Table("t_usuarios")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? UserID { get; set; }
        public  string? PrimerNombre { get; set; }
        public string? SegundoNombre { get; set; }
        [NotNull]
        public string? FotoPerfil { get; set; }
    }
}