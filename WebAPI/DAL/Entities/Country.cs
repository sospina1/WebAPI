using System.ComponentModel.DataAnnotations;

namespace WebAPI.DAL.Entities
{
    public class Country : AuditBase
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] // Campo obligatorio
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres.")] // Longitud Maxima
        [Display (Name = "Pais")] // Para identificar el nombre más fácil
        public String Name {  get; set; }
    }
}
