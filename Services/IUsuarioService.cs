using Projeto_Integrador_API.Models;

namespace Projeto_Integrador_API.Services
{
    public interface IUsuarioService
    {
        public Task<List<Usuario>> ObterUsuarios();
        public Task CriarUsuario(Usuario usuario);
    }
}