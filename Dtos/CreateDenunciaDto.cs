using System.ComponentModel.DataAnnotations;

namespace SistemaDenunciasMinimalApi.Dtos
{
    public class CreateDenunciaDto
    {
        [Required(ErrorMessage = "El campo 'Titulo' es obligatorio.")]
        [StringLength(25, ErrorMessage = "El campo 'Titulo' no puede exceder los 25 caracteres.")]
        public required string Titulo { get; set; }

        [Required(ErrorMessage = "El campo 'Descripcion' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo 'Descripcion' no puede exceder los 100 caracteres.")]
        public required string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo 'TipoId' es obligatorio.")]
        public int TipoId { get; set; }

        // campo cedula de usuario
        [Required(ErrorMessage = "El campo 'CedulaUsuario' es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo 'CedulaUsuario' no puede exceder los 10 caracteres.")]
        public required string CedulaUsuario { get; set; }
    }
}