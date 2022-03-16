using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Context;

namespace ToDo.Api.Context.Repository
{
    public class UserRepository : Repository<User>, IRepository<User>
    {
        public UserRepository(ToDoContext dbContext) : base(dbContext)
        {
        }
    }
}
