using Application.Common.Utils;
using Application.UseCases.Common.Handlers;
using Application.UseCases.Common.Results;
using MediatR;
using Microsoft.Extensions.Configuration;

namespace Application.UseCases.Files.Commands.CreateFileBlob;

public class CreateFileBlobCommand : CreateFileBlobCommandModel, IRequest<Result<CreateFileBlobCommandDto>>
{
    public class CreateFileCommandHandler(
        IConfiguration configuration) : UseCaseHandler, IRequestHandler<CreateFileBlobCommand, Result<CreateFileBlobCommandDto>>
    {
        public async Task<Result<CreateFileBlobCommandDto>> Handle(CreateFileBlobCommand request, CancellationToken cancellationToken)
        {
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images\\viva-mexico.jpg");
            var blobStorage = new BlobStorageService(configuration);
            var fileStream = System.IO.File.OpenRead(imagePath);
            try
            {
                blobStorage.UploadFile(request.Transaction.FileName, "jpg", fileStream);
            }
            catch (Exception ex) {
                var a = 0;
            }
            var resultData = new CreateFileBlobCommandDto { Created = true };

            return Succeded(resultData);
        }
    }
}

