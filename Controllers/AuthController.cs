using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TerminalBackend.Data;

namespace TerminalBackend.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AppDbContext _context;

    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        // Busca o usuário pelo e-mail
        var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == request.Email);

        // Se não achar ou a senha estiver errada (simples, sem criptografia por enquanto)
        if (usuario == null || usuario.Senha != request.Senha)
        {
            return Unauthorized(new { erro = "Email ou senha inválidos" });
        }

        // Se der certo, retorna o nome e o e-mail (Simulando um token)
        return Ok(new
        {
            mensagem = "Login autorizado",
            nome = usuario.Email.Split('@')[0], // Pega a parte antes do @
            email = usuario.Email
        });
    }
}