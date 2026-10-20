using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TerminalBackend.Data;
using TerminalBackend.Models;

namespace TerminalBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdensServicoController : ControllerBase
{
    private readonly AppDbContext _context;

    public OrdensServicoController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<OrdemServico>>> GetOrdens()
    {
        return await _context.OrdensServico.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<OrdemServico>> PostOrdem(OrdemServico os)
    {
        _context.OrdensServico.Add(os);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetOrdens), new { id = os.Id }, os);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutOrdem(int id, OrdemServico os)
    {
        if (id != os.Id) return BadRequest();
        _context.Entry(os).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOrdem(int id)
    {
        var os = await _context.OrdensServico.FindAsync(id);
        if (os == null) return NotFound();

        _context.OrdensServico.Remove(os);
        await _context.SaveChangesAsync();
        return NoContent();
    }
}