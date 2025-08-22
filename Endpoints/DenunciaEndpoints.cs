using SistemaDenunciasMinimalApi.Entities;
using SistemaDenunciasMinimalApi.Data;
using SistemaDenunciasMinimalApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace SistemaDenunciasMinimalApi.Endpoints;
public static class DenunciaEndpoints
{
    public static void MapDenunciaEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/denuncias")
        .WithParameterValidation();

        group.MapGet("/", async (DenunciaContext db) =>
        {
            var denuncias = await db.Denuncias.ToListAsync();
            return Results.Ok(denuncias.Select(d => d.ToSummaryDto(db)));
        });

        app.MapGet("/{id}", async (int id, DenunciaContext db) =>
        {
            var denuncia = await db.Denuncias.FindAsync(id);
            return denuncia is not null ? Results.Ok(denuncia.ToSummaryDto(db)) : Results.NotFound();
        });

        group.MapPost("/", async (CreateDenunciaDto createDenunciaDto, DenunciaContext db) =>
        {
            var denuncia = createDenunciaDto.ToEntity();
            db.Denuncias.Add(denuncia);
            await db.SaveChangesAsync();
            return Results.Created($"/denuncias/{denuncia.Id}", denuncia.ToDto());
        });

        group.MapPut("/{id}", async (int id, UpdateDenunciaDto updateDenunciaDto, DenunciaContext db) =>
        {
            var existingDenuncia = await db.Denuncias.FindAsync(id);
            if (existingDenuncia is null)
                return Results.NotFound();

            existingDenuncia.Descripcion = updateDenunciaDto.Descripcion;
            existingDenuncia.Titulo = updateDenunciaDto.Titulo;
            existingDenuncia.Estado = updateDenunciaDto.Estado;

            await db.SaveChangesAsync();
            return Results.NoContent();
        });

        group.MapDelete("/{id}", async (int id, DenunciaContext db) =>
        {
            var existingDenuncia = await db.Denuncias.FindAsync(id);
            if (existingDenuncia is null)
                return Results.NotFound();

            db.Denuncias.Remove(existingDenuncia);
            await db.SaveChangesAsync();
            return Results.NoContent();
        });
    }
}