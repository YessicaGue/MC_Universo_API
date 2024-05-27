using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MC_Universo_API.Data;
using MC_Universo_API.Models;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using MC_Universo_API.ViewModels;
using Azure.Core;

namespace MC_Universo_API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class PersonaController : ControllerBase
{
    private readonly UniversoContext _context;
    private readonly IMapper _mapper;

    public PersonaController(UniversoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    // GET: api/Persona
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Persona>>> Get()
    {
        return await _context.Persona.ToListAsync();
    }

    // GET: api/Persona/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Persona>> Get(int id)
    {
        var persona = await _context.Persona.FindAsync(id);

        return persona == null ? NotFound() : persona;
    }

    // POST: api/Persona
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Persona>> Post(PersonaViewModel request)
    {
        Persona persona = _mapper.Map<Persona>(request);
        _context.Persona.Add(persona);
        await _context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = persona.Id }, persona);
    }

    // PUT: api/Persona/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, PersonaViewModel request)
    {
        var persona = await _context.Persona.FindAsync(id);

        if (persona == null)
            return NotFound();

        _mapper.Map(request, persona);

        await _context.SaveChangesAsync();

        return CreatedAtAction("Get", new { id = persona.Id }, persona);
    }

    // DELETE: api/Persona/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var persona = await _context.Persona.FindAsync(id);

        if (persona == null)
            return NotFound();

        _context.Persona.Remove(persona);
        await _context.SaveChangesAsync();

        return Ok();
    }

    // GET: api/Persona/related
    [HttpGet("related")]
    public async Task<ActionResult<IEnumerable<Persona>>> GetRelated()
    {
        return await _context.Persona.ToListAsync();
    }

    // GET: api/Persona/related/5
    [HttpGet("related/{id}")]
    public async Task<ActionResult<Persona>> GetRelated(int id)
    {
        var persona = await _context.Persona.FindAsync(id);

        return persona == null ? NotFound() : persona;
    }
}