namespace SistemaDenunciasMinimalApi.Entities
{
    public class Denuncia
    {
        public int Id { get; set; }

        public string Titulo { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public int TipoId { get; set; }

        public int Estado { get; set; }
        
        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaFinalizacion { get; set; }

        public DateTime FechaUltimaActualizacion { get; set; }

        public required string CedulaUsuario { get; set; }

    }
}