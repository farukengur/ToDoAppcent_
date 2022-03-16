using ToDo.Shared.Contact;
using ToDo.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Service
{
    public interface ILoginService
    {
        Task<ApiResponse> Login(UserDto user);

        Task<ApiResponse> Resgiter(UserDto user);
    }
}
