using Crud.Api.Business.Models;

namespace Crud.Api.Business.Interfaces.IServices
{
    public interface IPessoaService : IDisposable
    {
        Task<bool> Adicionar(Pessoa pessoa);
        Task<bool> Atualizar(Pessoa pessoa);
        Task Excluir(Guid id);

    }
}
