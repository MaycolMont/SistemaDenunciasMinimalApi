using System.ComponentModel.DataAnnotations;

namespace SistemaDenunciasMinimalApi.Dtos;

public class DenunciaSummaryDto
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Descripcion { get; set; } = string.Empty;
    public string TipoDenunciaNombre { get; set; } = string.Empty;
    public string EstadoDenunciaNombre { get; set; } = string.Empty;
    public DateTime FechaCreacion { get; set; }
    public DateTime? FechaFinalizacion { get; set; }
    public DateTime FechaUltimaActualizacion { get; set; }
    public string CedulaUsuario { get; set; } = string.Empty;
}