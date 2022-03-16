using Microsoft.AspNetCore.Mvc;
using ToDo.Api.Context;
using ToDo.Api.Service;
using ToDo.Shared.Dtos;
using ToDo.Shared.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Api.Controllers
{
    
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService service;

        public LoginController(ILoginService service)
        {
            this.service = service;
        }

        [HttpPost]
        public async Task<ApiResponse> Login([FromBody] UserDto param) =>
            await service.LoginAsync(param.Account, param.PassWord);

        [HttpPost]
        public async Task<ApiResponse> Resgiter([FromBody] UserDto param) =>
            await service.Resgiter(param);

    }
}
