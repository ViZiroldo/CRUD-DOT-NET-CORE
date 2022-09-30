using Domain.Interfaces.IGeneric;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IRepositories
{
    public interface IPersonRepository : IRepository<Person>
    {
    }
}
