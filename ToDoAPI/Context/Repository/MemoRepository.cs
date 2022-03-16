using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Api;

namespace ToDoAPI.Context.Repository
{
    public class MemoRepository : Repository<Memo>, IRepository<Memo>

    {

        public MemoRepository(ToDoContext dbContext) : base(dbContext)
            { 
            }

    }
}
