using AutoMapper;
using Crud.Api.Business.Interfaces;
using Crud.Api.Business.Interfaces.IRepositories;
using Crud.Api.Business.Interfaces.IServices;
using Crud.Api.Business.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class PessoaController : MainController
    {
        #region Constructor
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IPessoaService _pessoaService;
        private readonly IMapper _mapper;

        public PessoaController(INotificador notificador, 
                                IPessoaRepository pessoaRepository,
                                IPessoaService pessoaService,
                                IMapper mapper) : base(notificador)
        {
            _pessoaRepository = pessoaRepository;
            _pessoaService = pessoaService;
            _mapper = mapper;
        }
        #endregion

        [HttpGet]
        [Route("ObterTodos")]
        public async Task<IEnumerable<PessoaViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<PessoaViewModel>>(await _pessoaRepository.ObterTodos());
        }

        [HttpGet]
        [Route("ObterPorId/{id:guid}")]
        public async Task<ActionResult<PessoaViewModel>> ObterPorId(Guid id)
        {
            return _mapper.Map<PessoaViewModel>(await _pessoaRepository.ObterPorId(id));
        }

        [HttpPost]
        [Route("Adicionar")]
        public async Task<ActionResult<PessoaViewModel>> Adicionar(PessoaViewModel pessoaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _pessoaService.Adicionar(_mapper.Map<Pessoa>(pessoaViewModel));

            return CustomResponse(pessoaViewModel);
        }

        [HttpPut]
        [Route("Atualizar/{id:guid}")]
        public async Task<ActionResult<PessoaViewModel>> Atualizar(PessoaViewModel pessoaViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _pessoaService.Atualizar(_mapper.Map<Pessoa>(pessoaViewModel));

            return CustomResponse(pessoaViewModel);
        }

        [HttpDelete]
        [Route("Excluir/{id:guid}")]
        public async Task<ActionResult<PessoaViewModel>> Excluir(Guid id)
        {
            var pessoaViewModel = await ObterPorId(id);

            if (pessoaViewModel.Value == null) 
            {
                NotificarErro("O id informado não foi encontrado na base, verifique se o mesmo esta correto!");
                return CustomResponse(pessoaViewModel);
            }

            await _pessoaService.Excluir(id);

            return CustomResponse(pessoaViewModel);
        }
    }
}
