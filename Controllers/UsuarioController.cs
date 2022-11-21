using Microsoft.AspNetCore.Mvc;
using Projeto_Integrador_API.Models;
using Projeto_Integrador_API.Services;

namespace Projeto_Integrador_API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _usuarioService;

    public UsuarioController(IUsuarioService service)
    {
        _usuarioService = service;
    }

    //Método temporário criado para testes.
    [HttpGet]
    [Route("ObterUsuarios")]
    public async Task<IActionResult> ObterUsuarios()
    {
        var usuarios = await _usuarioService.ObterUsuarios();

        return Ok(usuarios);
    }
}