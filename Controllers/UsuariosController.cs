using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TerminalBackend.Data;
using TerminalBackend.Models;

namespace TerminalBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsuariosController(AppDbContext context)
    {
        _context = context;
    }

    // POST: api/usuarios (Rota que o curl vai usar)
    [HttpPost]
    public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return Ok(usuario);
    }
}