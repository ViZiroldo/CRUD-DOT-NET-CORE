using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IService
{
    public interface IPersonService
    {
        Task Add(Person Objeto , string userLoggedId);
        //Task Update(Person Objeto);
        //Task<List<Person>> ListarMessageAtivas();
    }
}
