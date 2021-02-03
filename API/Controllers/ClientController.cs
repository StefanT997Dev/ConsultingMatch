using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Clients;
using ConsultingMatch.DataLayer;
using ConsultingMatch.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<Client>>> Get()
        {
            return await _mediator.Send(new List.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> Details(int id)
        {
            return await _mediator.Send(new Details.Query{Id=id});
        }

        [HttpGet("country/{id}")]
        public async Task<ActionResult<List<Client>>> GetFromCountry(int id)
        {
            return await _mediator.Send(new Usa.Query(){CountryId=id});
        }
        
        [HttpPost]
        public async Task<ActionResult<Unit>> Create(Client client)
        {
            return await _mediator.Send(new Create.Command(){Name=client.Name});
        }

    }
}
