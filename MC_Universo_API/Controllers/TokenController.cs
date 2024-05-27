using AutoMapper;
using DocumentFormat.OpenXml.InkML;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using MC_Universo_API.Utils;
using MC_Universo_API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MC_Universo_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly UniversoContext _context;
        private readonly IMapper _mapper;

        public TokenController(UniversoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<TokenController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Token>>> Get()
        {
            return await _context.Token.ToListAsync();
        }

        // GET api/<TokenController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Token>> Get(int id)
        {
            var token = await _context.Token.FindAsync(id);

            return token == null ? NotFound() : token;
        }

        // GET api/<TokenController>/5
        [HttpGet("p={id}/ct={ctid}")]
        public object getByPerfilIdAndCatalogoTokenId(int id, int ctid)
        {
            var perfilTokens = _context.PerfilToken
                .Where(pt => pt.PerfilId == id)
                .DefaultIfEmpty()
                .ToList();

            if (perfilTokens[0] == null)
                return new { };

            var token = perfilTokens
                .Select(pt =>
                    _context.Token
                        .Where(t => pt.TokenId == t.Id && t.CatalogoTokenId == ctid)
                        .FirstOrDefault()
                )
                .FirstOrDefault();

            if (token == null)
                return new { };

            return token;
        }

        // GET api/<TokenController>/5
        [HttpGet("u={id}/ct={ctid}")]
        public object getByUsuarioIdAndCatalogoTokenId(int id, int ctid)
        {
            var usuarioPerfil = _context.UsuarioPerfil.Where(up => up.UsuarioId == id).FirstOrDefault();
            if (usuarioPerfil == null)
                return new { };

            var perfilTokens = _context.PerfilToken
                .Where(pt => usuarioPerfil.PerfilId == pt.PerfilId)
                .DefaultIfEmpty()
                .ToList();

            if (perfilTokens[0] == null)
                return new { };

            var token = perfilTokens
                .Select(pt =>
                    _context.Token
                        .Where(t => pt.TokenId == t.Id && t.CatalogoTokenId == ctid)
                        .FirstOrDefault()
                )
                .FirstOrDefault();

            if (token == null)
                return new { };

            return token;
        }

        // GET api/<TokenController>/5
        [HttpGet("{id}/ct={ctid}")]
        public object getByPerfilGrupalIdAndCatalogoTokenId(int id, int ctid)
        {
            var perfilTokens = _context.PerfilGrupalToken
                .Where(pt => pt.PerfilGrupalId == id)
                .DefaultIfEmpty()
                .ToList();

            if (perfilTokens[0] == null)
                return new { };

            var token = perfilTokens
                .Select(pt =>
                    _context.Token
                        .Where(t => pt.TokenId == t.Id && t.CatalogoTokenId == ctid)
                        .FirstOrDefault()
                )
                .FirstOrDefault();

            if (token == null)
                return new { };

            return token;
        }

        // POST api/<TokenController>
        [HttpPost("store/p={id}")]
        public async Task<ActionResult<Token>> StorePerfilToken(int id, TokenViewModel request)
        {
            Token token = _mapper.Map<Token>(request);
            _context.Token.Add(token);
            await _context.SaveChangesAsync();

            PerfilTokenViewModel perfilTokenVM = new PerfilTokenViewModel { TokenId = token.Id, PerfilId = id };
            PerfilToken perfilToken = _mapper.Map<PerfilToken>(perfilTokenVM);
            _context.PerfilToken.Add(perfilToken);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = token.Id }, token);
        }

        // POST api/<TokenController>
        [HttpPost("store/perfil-grupal/{id}")]
        public async Task<ActionResult<Token>> StorePerfilGrupalToken(int id, TokenViewModel request)
        {
            Token token = _mapper.Map<Token>(request);
            _context.Token.Add(token);
            await _context.SaveChangesAsync();

            PerfilGrupalTokenViewModel perfilTokenVM = new PerfilGrupalTokenViewModel { TokenId = token.Id, PerfilGrupalId = id };
            PerfilGrupalToken perfilGrupalToken = _mapper.Map<PerfilGrupalToken>(perfilTokenVM);
            _context.PerfilGrupalToken.Add(perfilGrupalToken);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = token.Id }, token);
        }

        // POST api/<TokenController>
        [HttpPost]
        public async Task<ActionResult<Token>> Post(TokenViewModel request)
        {
            Token token = _mapper.Map<Token>(request);
            _context.Token.Add(token);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = token.Id }, token);
        }
        
        // POST token facebook api/<TokenController>
        [HttpPost("store/token/facebook/{perfil_id}")]
        public async Task<ActionResult<Token>> StoreFacebookToken(int perfil_id, [FromBody] TokenViewModel tokenViewModel)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    //insertar en tabla token
                    var token = _mapper.Map<Token>(tokenViewModel);
                    _context.Token.Add(token);
                    await _context.SaveChangesAsync();
                    var tokenPerfil = new PerfilToken
                    {
                        PerfilId = perfil_id,
                        TokenId = token.Id
                    };
                    _context.PerfilToken.Add(tokenPerfil);
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return CreatedAtAction("Get", new { id = token.Id }, token);
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    return BadRequest(ex.Message);
                }
            }
        }
        
        // PUT api/<TokenController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TokenViewModel request)
        {
            var token = await _context.Token.FindAsync(id);
            _mapper.Map(request, token);

            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = token.Id }, token);
        }

        [HttpGet("cron/get-near-expired-tokens")]
        public object CronGetNearExpiredTokens()
        {
            return from token in _context.Set<Token>()

                   let catalogoTokens = _context.CatalogoTokens
                    .Where(catalogoTokens => token.CatalogoTokenId == catalogoTokens.Id)
                    .FirstOrDefault()

                   where token.Expirable == true
                   where token.SegundosExpira != null
                   where (token.FechaActualizacion.AddSeconds(token.SegundosExpira != null ? (double) token.SegundosExpira : 0.0) - DateTime.UtcNow).TotalDays < 10
                   where token.Activo == true

                   select new
                   {
                       id = token.Id,
                       nombre = token.Nombre,
                       stringifiedToken = token.StringifiedToken,
                       expirable = token.Expirable,
                       segundosExpira = token.SegundosExpira,
                       activo = token.Activo,
                       fechaCreacion = token.FechaCreacion,
                       fechaActualizacion = token.FechaActualizacion,
                       catalogoTokens
                   };
        }

        // POST api/<TokenController>/v2/store
        [HttpPost("v2/store")]
        public async Task<ActionResult<Token>> PostV2(
            TokenViewModel request,
            [FromQuery] bool? is_grupal,
            [FromQuery] int perfil_id
        )
        {
            bool wasGrupal = is_grupal ?? false;

            // Retrieves all tokens
            var perfilTokens = wasGrupal
                ? await _context.PerfilGrupalToken
                    .Where(perfilToken =>
                        perfil_id == perfilToken.PerfilGrupalId
                            && perfilToken.Activo
                    )
                    .Select(perfilToken => new
                    {
                        PerfilId = perfil_id,
                        TokenId = perfilToken != null ? perfilToken.TokenId : 0
                    })
                    .DefaultIfEmpty()
                    .ToListAsync()
                : await _context.PerfilToken
                    .Where(perfilToken =>
                        perfil_id == perfilToken.PerfilId
                            && perfilToken.Activo
                    )
                    .Select(perfilToken => new
                    {
                        PerfilId = perfil_id,
                        TokenId = perfilToken != null ? perfilToken.TokenId : 0
                    })
                    .DefaultIfEmpty()
                    .ToListAsync();

            // Tries to match desired type of token
            var tokenTask = perfilTokens
                .Select(async perfilToken =>
                    await _context.Token
                        .Where(token =>
                            perfilToken != null
                                && perfilToken.TokenId == token.Id
                                && request.CatalogoTokenId == token.CatalogoTokenId
                        )
                        .FirstOrDefaultAsync()
                )
                .FirstOrDefault();

            // If matched token was found then it updates
            if (
                tokenTask != null &&
                tokenTask.Result != null
            )
            {
                var tokenResult = tokenTask.Result;
                tokenResult.StringifiedToken = request.StringifiedToken;
                tokenResult.SegundosExpira = request.SegundosExpira;
                tokenResult.Expirable = request.Expirable;
                tokenResult.FechaActualizacion = DateTime.UtcNow;

                _context.Token.Update(tokenResult);
                await _context.SaveChangesAsync();

                return Ok();
            }

            // Otherwise token and relation will be created thru transaction
            using (var dbContextTransaction = _context.Database.BeginTransaction())
            {
                try
                {
                    Token token = _mapper.Map<Token>(request);
                    _context.Token.Add(token);
                    await _context.SaveChangesAsync();

                    if (wasGrupal)
                    {
                        PerfilGrupalToken perfilGrupalToken = new PerfilGrupalToken
                        {
                            TokenId = token.Id,
                            PerfilGrupalId = perfil_id
                        };
                        _context.PerfilGrupalToken.Add(perfilGrupalToken);
                    }
                    else
                    {
                        PerfilToken perfilToken = new PerfilToken
                        {
                            TokenId = token.Id,
                            PerfilId = perfil_id
                        };
                        _context.PerfilToken.Add(perfilToken);
                    }
                    await _context.SaveChangesAsync();

                    await dbContextTransaction.CommitAsync();
                    return Ok();
                }
                catch (Exception e)
                {
                    await dbContextTransaction.RollbackAsync();
                    var response = new ApiResponse<string>
                    {
                        Success = false,
                        StatusCode = 400,
                        Message = e.InnerException.Message ?? e.Message,
                    };
                    return BadRequest(response);
                }
            }
        }
    }
}
