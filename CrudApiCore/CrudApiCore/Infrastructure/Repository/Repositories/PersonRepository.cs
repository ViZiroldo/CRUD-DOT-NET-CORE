using Domain.Interfaces.IRepositories;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        #region Constructor
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;

        public PersonRepository()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        #endregion



    }
}
