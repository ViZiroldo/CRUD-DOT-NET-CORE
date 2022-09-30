using Domain.Interfaces.Generic;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IService;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class PersonService : IPersonService
    {
        #region Constructor
        private readonly IPersonRepository _iRepositoryPerson;

        public PersonService(IPersonRepository iRepositoryPerson)
        {
            _iRepositoryPerson = iRepositoryPerson;
        }
        #endregion


        public async Task Add(Person Objeto, string userLoggedId)
        {
            try
            {
                await _iRepositoryPerson.Add(Objeto);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public async Task Update(Person Objeto)
        //{
        //    var validatitulo = Objeto.ValidarPropriedadeString(Objeto.Titulo, "Titulo");
        //    if (validatitulo)
        //    {
        //        Objeto.DataAlteracao = DateTime.Now;
        //        await _iPerson.Update(Objeto);
        //    }
        //}

        //public async Task<List<Message>> ListarMessageAtivas()
        //{
        //    return await _iPerson.ListarMessage(n => n.Ativo);
        //}
    }
}
