using AutoMapper;
using MC_Universo_API.Data;
using MC_Universo_API.Models.Candidatos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MC_Universo_API.Controllers.Candidatos;

[Route("api/[controller]")]
[ApiController]
public class AvataresController(UniversoContext context, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AvatarCandidato>>> GetAvatares()
    {
        return await context.Avatares.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AvatarCandidato>> GetAvatar(int id)
    {
        var avatar = await context.Avatares.FindAsync(id);

        if (avatar == null)
        {
            return NotFound();
        }

        return avatar;
    }
    
    // Get Avatar By PerfilId
    [HttpGet("perfil/{perfilId}")]
    public async Task<ActionResult<AvatarCandidato>> GetAvatarByPerfilId(int perfilId)
    {
        var avatar = await context.Avatares.FirstOrDefaultAsync(a => a.PerfilId == perfilId);

        if (avatar == null)
        {
            return NotFound();
        }

        return avatar;
    }
}