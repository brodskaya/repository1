using Microsoft.AspNetCore.Mvc;
using MediatR;
using OutstaffSystem.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using OutstaffSystem.Application.Contractors.Queries;
using OutstaffSystem.Application.Contractors.Commands;


namespace OutstaffSystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContractorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContractorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<ContractorDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllContractorsQuery());
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ContractorDto contractor)
        {
            var id = await _mediator.Send(new CreateContractorCommand(contractor));
            return Ok(id);
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] ContractorDto contractor)
        {
            await _mediator.Send(new EditContractorCommand(contractor));
            return NoContent();
        }
    }
}