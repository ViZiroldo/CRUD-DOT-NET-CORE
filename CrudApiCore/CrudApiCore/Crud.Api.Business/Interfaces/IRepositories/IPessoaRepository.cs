using Crud.Api.Business.Models;

namespace Crud.Api.Business.Interfaces.IRepositories
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Task<bool> VerificarCPF(string CPF);
        Task Excluir(Guid id);
        Task Alterar(Pessoa pessoa);
    }
}
