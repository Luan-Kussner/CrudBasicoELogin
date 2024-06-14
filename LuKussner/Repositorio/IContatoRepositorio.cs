using LuKussner.Models;

namespace LuKussner.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> ListarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
