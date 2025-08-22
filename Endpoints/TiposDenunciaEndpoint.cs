using SistemaDenunciasMinimalApi.Data;
using Microsoft.EntityFrameworkCore;    

namespace SistemaDenunciasMinimalApi.Endpoints;

public static class TiposDenunciaEndpoint
{
    public static RouteGroupBuilder MapTiposDenunciaEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/tipos-denuncia");

        group.MapGet("/", async (DenunciaContext db) =>
        {
            var tiposDenuncias = await db.TiposDenuncia.ToListAsync();
            return Results.Ok(tiposDenuncias);
        });

        return group;
    }
}