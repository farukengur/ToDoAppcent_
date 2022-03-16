using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoAPI.Context;

namespace ToDo.Api.Context.Repository
{
    public class ToDoRepository : Repository<TooDo>, IRepository<TooDo>
    {
        public ToDoRepository(ToDoContext dbContext) : base(dbContext)
        {
        }
    }
}
