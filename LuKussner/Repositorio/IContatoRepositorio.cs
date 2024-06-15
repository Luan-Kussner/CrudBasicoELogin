using LuKussner.Models;

namespace LuKussner.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel BuscarPorId(int id);

        List<ContatoModel> ListarTodos();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Alterar(ContatoModel contato);
    }
}
