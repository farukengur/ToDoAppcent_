using ToDo.Shared.Contact;
using ToDo.Shared.Dtos;
using ToDo.Shared.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Service
{
    public interface IToDoService : IBaseService<ToDoDto>
    {
        Task<ApiResponse<PagedList<ToDoDto>>> GetAllFilterAsync(ToDoParameter parameter);

        Task<ApiResponse<SummaryDto>> SummaryAsync();
    }
}
