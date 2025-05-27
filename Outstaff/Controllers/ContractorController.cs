using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Runtime.InteropServices;
using Outstaff.DTOs;
using Outstaff.CQ;
namespace Outstaff.Controllers { }
[ApiController]
[Route("api/[controller]")]
public class ContractorsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ContractorsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateContractorDto dto)
    {
        var command = new CreateContractorCommand
        {
            FullName = dto.FullName,
            Email = dto.Email
        };

        var result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] UpdateContractorDto dto)
    {
        if (id != dto.Id) return BadRequest();

        var command = new UpdateContractorCommand
        {
            Id = dto.Id,
            FullName = dto.FullName,
            Email = dto.Email
        };

        var result = await _mediator.Send(command);
        return Ok(result);
    }
}