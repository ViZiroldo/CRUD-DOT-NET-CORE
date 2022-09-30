using Crud.Api.Business.Interfaces;
using Crud.Api.Business.Interfaces.IRepositories;
using Crud.Api.Business.Interfaces.IServices;
using Crud.Api.Business.Models;
using Crud.Api.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Api.Business.Services
{
    public class PessoaService : BaseService, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository,
                             INotificador notificador) : base(notificador)
        {
            _pessoaRepository = pessoaRepository;
        }

        

        public async Task<bool> Adicionar(Pessoa pessoa)
        {
            if (!ExecutarValidacao(new PessoaValidation(), pessoa)) return false;

            var validaCPF = VerificarCPF(pessoa.CPF);

            if (validaCPF.Result == true)
            {
                Notificar("Este CPF já esta cadastrado!");
                return false;
            }

            await _pessoaRepository.Adicionar(pessoa);
            return true;
        }

        public async Task<bool> Atualizar(Pessoa pessoa)
        {
            if (!ExecutarValidacao(new PessoaValidation(), pessoa)) return false;

            var cadastro = _pessoaRepository.Buscar(x => x.CPF == pessoa.CPF).Result.SingleOrDefault();

            if (cadastro.CPF != pessoa.CPF)
            {
                var validaCPF = VerificarCPF(pessoa.CPF);

                if (validaCPF.Result == true)
                {
                    Notificar("Este CPF já esta cadastrado!");
                    return false;
                }
            }

            await _pessoaRepository.Atualizar(pessoa);
            return true;
        }

        public async Task Excluir(Guid id)
        {
            await _pessoaRepository.Excluir(id);
        }

        public async Task<bool> VerificarCPF(string CPF)
        {
            var result = await _pessoaRepository.VerificarCPF(CPF);

            return result;
        }

        public void Dispose()
        {
            _pessoaRepository?.Dispose();
        }
    }
}
