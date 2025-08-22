using System.ComponentModel.DataAnnotations;

namespace SistemaDenunciasMinimalApi.Dtos
{
    public class DenunciaDto
    {
        [Required(ErrorMessage = "El campo 'Id' es obligatorio.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo 'Titulo' es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo 'Titulo' no puede exceder los 100 caracteres.")]
        public required string Titulo { get; set; }

        [Required(ErrorMessage = "El campo 'Descripcion' es obligatorio.")]
        [StringLength(500, ErrorMessage = "El campo 'Descripcion' no puede exceder los 500 caracteres.")]
        public required string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo 'TipoId' es obligatorio.")]
        public int TipoId { get; set; }

        [Required(ErrorMessage = "El campo 'Estado' es obligatorio.")]
        public required int Estado { get; set; }

        [Required(ErrorMessage = "El campo 'FechaCreacion' es obligatorio.")]
        public DateTime FechaCreacion { get; set; }

        // campo fecha finalizacion
        [Required(ErrorMessage = "El campo 'FechaFinalizacion' es obligatorio.")]
        public DateTime? FechaFinalizacion { get; set; }

        // campo fecha ultima actualizacion
        [Required(ErrorMessage = "El campo 'FechaUltimaActualizacion' es obligatorio.")]
        public DateTime FechaUltimaActualizacion { get; set; }
        
        [Required(ErrorMessage = "El campo 'CedulaUsuario' es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo 'CedulaUsuario' no puede exceder los 10 caracteres.")]
        public required string CedulaUsuario { get; set; }
    }
}