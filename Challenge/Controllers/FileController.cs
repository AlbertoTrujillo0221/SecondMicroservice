using Api.Controllers;
using Application.UseCases.Files.Commands.CreateFile;
using Application.UseCases.Files.Queries.GetFilesNames;
using Application.UseCases.Transactions.Queries.GetTransactions;
using Microsoft.AspNetCore.Mvc;

namespace Challenge.Controllers
{
    public class FileController : BaseController
    {
        [HttpGet]
        [Route("GetAll")]
        [Produces(typeof(GetFilesNamesQueryDto))]
        [ActionName(nameof(GetAll))]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetFilesNamesQuery();
            var result = await this.Mediator.Send(query);
            return this.FromResult(result);
        }

        [HttpPost]
        [Route("Create")]
        [Produces(typeof(CreateFileCommandDto))]
        [ActionName(nameof(Create))]
        public async Task<IActionResult> Create(CreateFileCommandModel model)
        {
            var command = this.Mapper.Map<CreateFileCommand>(model);
            var result = await this.Mediator.Send(command);
            return this.FromResult(result);
        }
    }
}
