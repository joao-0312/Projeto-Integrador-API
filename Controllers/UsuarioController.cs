using Microsoft.AspNetCore.Mvc;
using Projeto_Integrador_API.Models;

namespace Projeto_Integrador_API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    //Método temporário criado para testes.
    [HttpGet]
    [Route("ObterUsuarios")]
    public List<Usuario> ObterUsuarios()
    {
        return new List<Usuario>();
    }
}