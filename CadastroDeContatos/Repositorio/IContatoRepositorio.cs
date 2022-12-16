using CadastroDeContatos.Models;

namespace CadastroDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarPorId(int id);
        Task<List<ContatoModel>> BuscarTodos();
        Task<ContatoModel> Adicionar(ContatoModel contato);
        ContatoModel Atualizar(ContatoModel contato);
        bool Apagar(int id);
    }
}
