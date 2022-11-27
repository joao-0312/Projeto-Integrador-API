namespace Projeto_Integrador_API.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
    }
}