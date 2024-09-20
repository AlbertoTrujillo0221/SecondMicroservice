using Application.UseCases.Files.Commands.CreateFile;
using Application.UseCases.Files.Commands.CreateFileBlob;
using AutoMapper;

namespace Application.Common.Mappings;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        this.CreateMap<CreateFileCommandModel, CreateFileCommand>();
        this.CreateMap<CreateFileBlobCommandModel, CreateFileBlobCommand>();
    }
}
