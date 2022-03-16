using AutoMapper.Configuration;
using ToDo.Api.Context;
using ToDo.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ToDoAPI.Context;

namespace MyToDo.Api.Extensions
{
    public class AutoMapperProFile : MapperConfigurationExpression
    {
        public AutoMapperProFile()
        {
            CreateMap<TooDo, ToDoDto>().ReverseMap();
            CreateMap<Memo, MemoDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
