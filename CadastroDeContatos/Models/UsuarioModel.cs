using CadastroDeContatos.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection.PortableExecutable;

namespace CadastroDeContatos.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do usuário")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o Login do Usuário")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o Email do Usuário")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Selecione o Perfil do Usario")]
        public PerfilEnum Perfil { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }

        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}
