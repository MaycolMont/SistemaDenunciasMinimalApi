using System.ComponentModel.DataAnnotations;

namespace SistemaDenunciasMinimalApi.Dtos
{
    public class UpdateDenunciaDto
    {
        [Required(ErrorMessage = "El campo 'Titulo' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo 'Titulo' no puede exceder los 100 caracteres.")]
        public required string Titulo { get; set; }

        [Required(ErrorMessage = "El campo 'Descripcion' es obligatorio.")]
        [StringLength(500, ErrorMessage = "El campo 'Descripcion' no puede exceder los 500 caracteres.")]
        public required string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo 'Estado' es obligatorio.")]
        public required int Estado { get; set; }
    }
}