using SistemaDenunciasMinimalApi.Data;
using SistemaDenunciasMinimalApi.Dtos;

namespace SistemaDenunciasMinimalApi.Entities
{
    public static class DenunciaMapping
    {
        public static Denuncia ToEntity(this CreateDenunciaDto dto)
        {
            return new Denuncia
            {
                Titulo = dto.Titulo,
                Descripcion = dto.Descripcion,
                TipoId = dto.TipoId,
                Estado = 1,
                FechaCreacion = DateTime.Now,
                FechaUltimaActualizacion = DateTime.Now,
                CedulaUsuario = dto.CedulaUsuario
            };
        }

        public static DenunciaSummaryDto ToSummaryDto(this Denuncia denuncia, DenunciaContext db)
        {
            return new DenunciaSummaryDto
            {
                Id = denuncia.Id,
                Titulo = denuncia.Titulo,
                Descripcion = denuncia.Descripcion,
                TipoDenunciaNombre = db.TiposDenuncia
                    .Where(t => t.Id == denuncia.TipoId)
                    .Select(t => t.Nombre)
                    .FirstOrDefault() ?? "Desconocido",
                EstadoDenunciaNombre = db.estadosDenuncia
                    .Where(e => e.Id == denuncia.Estado)
                    .Select(e => e.Nombre)
                    .FirstOrDefault() ?? "Desconocido",
                FechaCreacion = denuncia.FechaCreacion,
                FechaFinalizacion = denuncia.FechaFinalizacion,
                FechaUltimaActualizacion = denuncia.FechaUltimaActualizacion,
                CedulaUsuario = denuncia.CedulaUsuario
            };
        }

        public static DenunciaDto ToDto(this Denuncia denuncia)
        {
            return new DenunciaDto
            {
                Id = denuncia.Id,
                Titulo = denuncia.Titulo,
                Descripcion = denuncia.Descripcion,
                TipoId = denuncia.TipoId,
                Estado = denuncia.Estado,
                FechaCreacion = denuncia.FechaCreacion,
                FechaFinalizacion = denuncia.FechaFinalizacion,
                FechaUltimaActualizacion = denuncia.FechaUltimaActualizacion,
                CedulaUsuario = denuncia.CedulaUsuario
            };
        }
    }
}