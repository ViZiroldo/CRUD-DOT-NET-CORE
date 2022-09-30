using AutoMapper;
using Crud.Api.Business.Models;
using WebApi.Models;

namespace WebApi.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<Pessoa, PessoaViewModel>().ReverseMap();
        }
    }
}
