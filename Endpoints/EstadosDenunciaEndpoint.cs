using SistemaDenunciasMinimalApi.Data;
using Microsoft.EntityFrameworkCore;    

namespace SistemaDenunciasMinimalApi.Endpoints;

public static class EstadosDenunciaEndpoint
{
    public static RouteGroupBuilder MapEstadosDenunciaEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/estados-denuncia");

        group.MapGet("/", async (DenunciaContext db) =>
        {
            var estadosDenuncias = await db.estadosDenuncia.ToListAsync();
            return Results.Ok(estadosDenuncias);
        });

        return group;
    }
}