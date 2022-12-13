using System.ComponentModel.DataAnnotations;

namespace CadastroDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome do Contato")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o email do Contato")]
        [EmailAddress(ErrorMessage = "O email informado não é valido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o celular do Contato")]
        [Phone(ErrorMessage = "O celular informado não é valido")]
        public string Celular { get; set; }
    }
}
