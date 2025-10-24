using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionEscolarMVC.Models
{
    public class Materia
    {
        [Key]
        public int MateriaId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}