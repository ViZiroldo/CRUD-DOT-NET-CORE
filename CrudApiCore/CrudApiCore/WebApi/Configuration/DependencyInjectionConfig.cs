using Crud.Api.Business.Interfaces;
using Crud.Api.Business.Interfaces.IRepositories;
using Crud.Api.Business.Interfaces.IServices;
using Crud.Api.Business.Services;
using Crud.Api.Data.Context;
using Crud.Api.Data.Repository;
using DevIO.Business.Notificacoes;

namespace WebApi.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<ContextBase>();
            services.AddScoped<IPessoaRepository, PessoaRepository>();
            services.AddScoped<IPessoaService, PessoaService>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
