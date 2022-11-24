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

        public async Task<Usuario> BuscarUsuario(int id)
        {
            var usuario = await _appDbContext.Usuarios.FindAsync(id);

            if(usuario == null)
                throw new Exception("Usuário não encontrado.");

            return usuario;
        }

        public async Task CriarUsuario(Usuario usuario)
        {
                if(ValidarUsuario(usuario))
                {
                    await _appDbContext.Usuarios.AddAsync(usuario);
                    await _appDbContext.SaveChangesAsync();
                }      
        }

        private bool ValidarUsuario(Usuario usuario)
        {
            List<string> mensagensErro = new List<string>();
            usuario.Nome = usuario.Nome.Trim();

            if(usuario.Nome == "")
                mensagensErro.Add("Insira seu nome.");

            DateTime dezoitoAnosAtras = DateTime.Now.AddYears(-18);
            if(DateTime.Compare(usuario.DataNascimento, dezoitoAnosAtras) > 0)
                mensagensErro.Add("Você deve ser maior de idade para criar uma conta.");

            if(usuario.Genero == "")
                mensagensErro.Add("Insira seu gênero."); 

            if(mensagensErro.Count > 0)
                throw new Exception(String.Join(';', mensagensErro));
            
            return true;
        }
    }
}