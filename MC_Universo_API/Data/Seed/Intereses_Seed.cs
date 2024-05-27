using MC_Universo_API.Models;

namespace MC_Universo_API.Data.Seed;

public class Intereses_Seed
{
    private const string UrlImageTmp = "https://images.unsplash.com/photo-1588591795084-1770cb3be374?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=2070&q=80";

    public readonly List<GrupoIntereses> GruposIntereses = new()
    {
        new GrupoIntereses {Id = 1, Nombre = "Economía", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 2,  Nombre = "Fotografía", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 3,  Nombre = "Viajes", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 4,  Nombre = "Medio Ambiente", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 5,  Nombre = "Cocina", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 6,  Nombre = "Tecnología", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 7,  Nombre = "Moda", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 8,  Nombre = "Juegos", Activo = true, UrlImagen = UrlImageTmp },
        new GrupoIntereses {Id = 9,  Nombre = "Otros", Activo = true, UrlImagen = UrlImageTmp }
    };
    
    public readonly List<Interes> Intereses = new()
    {
        new Interes {Id = 1,  Nombre = "Inversiones", Activo = true },
        new Interes {Id = 2,  Nombre = "Acciones", Activo = true },
        new Interes {Id = 3,  Nombre = "Emancipación", Activo = true },
        new Interes {Id = 4,  Nombre = "Criptomonedas", Activo = true },
        new Interes {Id = 5,  Nombre = "Finanzas", Activo = true },
        new Interes {Id = 6,  Nombre = "Trading", Activo = true },
        new Interes {Id = 7,  Nombre = "Fotografía artística", Activo = true },
        new Interes {Id = 8,  Nombre = "Fotografía conceptual", Activo = true },
        new Interes {Id = 9,  Nombre = "Fotografía en blanco y negro", Activo = true },
        new Interes {Id = 10,  Nombre = "Fotografía minimalista", Activo = true },
        new Interes {Id = 11,  Nombre = "Fotografía abstracta", Activo = true },
        new Interes {Id = 12,  Nombre = "Fotografía de retrato", Activo = true },
        new Interes {Id = 13,  Nombre = "Turismo de aventura", Activo = true },
        new Interes {Id = 14,  Nombre = "Turismo rural", Activo = true },
        new Interes {Id = 15,  Nombre = "Turismo de naturaleza", Activo = true },
        new Interes {Id = 16,  Nombre = "Turismo paranormal", Activo = true },
        new Interes {Id = 17,  Nombre = "Movimientos para cuidado del agua", Activo = true },
        new Interes {Id = 18,  Nombre = "Concientización de cambio climático", Activo = true },
        new Interes {Id = 19,  Nombre = "Control de plagas", Activo = true },
        new Interes {Id = 20,  Nombre = "Solidaridad en desastres naturales", Activo = true },
        new Interes {Id = 21,  Nombre = "Protección de flora y fauna", Activo = true },
        new Interes {Id = 22,  Nombre = "Cocina tradicional", Activo = true },
        new Interes {Id = 23,  Nombre = "Cocina recreativa", Activo = true },
        new Interes {Id = 24,  Nombre = "Alta cocina", Activo = true },
        new Interes {Id = 25,  Nombre = "Comida italiana", Activo = true },
        new Interes {Id = 26,  Nombre = "Comida libanesa", Activo = true },
        new Interes {Id = 27,  Nombre = "Comida japonesa", Activo = true },
        new Interes {Id = 28,  Nombre = "Comida peruana", Activo = true },
        new Interes {Id = 29,  Nombre = "Comida mexicana", Activo = true }
    };

    public readonly List<InteresGrupoIntereses> InteresesUnion = new()
    {
        new InteresGrupoIntereses {Id = 1, InteresId = 1, GrupoInteresesId = 1 },
        new InteresGrupoIntereses {Id = 2, InteresId = 2, GrupoInteresesId = 1 },
        new InteresGrupoIntereses {Id = 3, InteresId = 3, GrupoInteresesId = 1 },
        new InteresGrupoIntereses {Id = 4, InteresId = 4, GrupoInteresesId = 1 },
        new InteresGrupoIntereses {Id = 5, InteresId = 5, GrupoInteresesId = 1 },
        new InteresGrupoIntereses {Id = 6, InteresId = 6, GrupoInteresesId = 1 },
        new InteresGrupoIntereses {Id = 7, InteresId = 7, GrupoInteresesId = 2 },
        new InteresGrupoIntereses {Id = 8, InteresId = 8, GrupoInteresesId = 2 },
        new InteresGrupoIntereses {Id = 9, InteresId = 9, GrupoInteresesId = 2 },
        new InteresGrupoIntereses {Id = 10, InteresId = 10, GrupoInteresesId = 2 },
        new InteresGrupoIntereses {Id = 11, InteresId = 11, GrupoInteresesId = 2 },
        new InteresGrupoIntereses {Id = 12, InteresId = 12, GrupoInteresesId = 2 },
        new InteresGrupoIntereses {Id = 13, InteresId = 13, GrupoInteresesId = 3 },
        new InteresGrupoIntereses {Id = 14, InteresId = 14, GrupoInteresesId = 3 },
        new InteresGrupoIntereses {Id = 15, InteresId = 15, GrupoInteresesId = 3 },
        new InteresGrupoIntereses {Id = 16, InteresId = 16, GrupoInteresesId = 3 },
        new InteresGrupoIntereses {Id = 17, InteresId = 17, GrupoInteresesId = 4 },
        new InteresGrupoIntereses {Id = 18, InteresId = 18, GrupoInteresesId = 4 },
        new InteresGrupoIntereses {Id = 19, InteresId = 19, GrupoInteresesId = 4 },
        new InteresGrupoIntereses {Id = 20, InteresId = 20, GrupoInteresesId = 4 },
        new InteresGrupoIntereses {Id = 21, InteresId = 21, GrupoInteresesId = 4 },
        new InteresGrupoIntereses {Id = 22, InteresId = 22, GrupoInteresesId = 5 },
        new InteresGrupoIntereses {Id = 23, InteresId = 23, GrupoInteresesId = 5 },
        new InteresGrupoIntereses {Id = 24, InteresId = 24, GrupoInteresesId = 5 },
        new InteresGrupoIntereses {Id = 25, InteresId = 25, GrupoInteresesId = 5 },
        new InteresGrupoIntereses {Id = 26, InteresId = 26, GrupoInteresesId = 5 },
        new InteresGrupoIntereses {Id = 27, InteresId = 27, GrupoInteresesId = 5 },
        new InteresGrupoIntereses {Id = 28, InteresId = 28, GrupoInteresesId = 5 },
        new InteresGrupoIntereses {Id = 29, InteresId = 29, GrupoInteresesId = 5 }
    };
}