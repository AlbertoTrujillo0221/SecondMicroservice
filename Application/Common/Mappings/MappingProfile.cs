using Application.UseCases.Files.Commands.CreateFile;
using AutoMapper;

namespace Application.Common.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap<CreateFileCommandModel, CreateFileCommand>();
    }
}
