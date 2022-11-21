using Microsoft.EntityFrameworkCore;
using Projeto_Integrador_API.Data;
using Projeto_Integrador_API.Models;

namespace Projeto_Integrador_API.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _appDbContext;

        public UsuarioService(AppDbContext context)
        {
            _appDbContext = context;
        }

        public async Task<List<Usuario>> ObterUsuarios()
        {
            var usuarios = await _appDbContext
            .Usuarios
            .ToListAsync();

            return usuarios;
        }

    }
}