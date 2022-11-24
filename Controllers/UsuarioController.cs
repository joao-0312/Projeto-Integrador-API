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

    [HttpGet]
    [Route("ObterUsuarios")]
    public async Task<IActionResult> ObterUsuarios()
    {
        try 
        {
            var usuarios = await _usuarioService.ObterUsuarios();

            return Ok(usuarios);
        }
        catch (Exception ex)
        {
            return  BadRequest(ex.Message);
        }
    }

    [HttpPost]
    [Route("CriarUsuario")]
    public async Task<IActionResult> CriarUsuario(Usuario usuario)
    {
        try
        {
            await _usuarioService.CriarUsuario(usuario);
            
            return Ok("Conta criada com sucesso.");
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}