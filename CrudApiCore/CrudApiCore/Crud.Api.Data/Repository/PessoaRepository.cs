using Crud.Api.Business.Interfaces.IRepositories;
using Crud.Api.Business.Models;
using Crud.Api.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Crud.Api.Data.Repository
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ContextBase context) : base(context) { }

        public async Task<bool> VerificarCPF(string CPF)
        {
            var result = await Db.Pessoas.FirstOrDefaultAsync(x => x.CPF == CPF);
            if (result == null)
            {
                return false;
            }

            return true; 
        }

        public async Task Excluir(Guid id)
        {
            var pessoa = await Db.Pessoas.SingleOrDefaultAsync(x => x.Id == id);

            Db.Pessoas.Remove(pessoa);
            Db.SaveChanges();
        }

        public async Task Alterar(Pessoa pessoa)
        {
            Db.Pessoas.UpdateRange(pessoa);
            Db.SaveChanges();
        }

    }
}
