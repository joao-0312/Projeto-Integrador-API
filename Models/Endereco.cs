namespace Projeto_Integrador_API.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento {get ; set;}
        public string CEP { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}