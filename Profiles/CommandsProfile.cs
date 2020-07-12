using AutoMapper;
using CommanderWebApi.Dtos;
using CommanderWebApi.Models;

namespace CommanderWebApi.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandCreateDto, Command>();
            CreateMap<CommandUpdateDto, Command>();
        }

    }
}