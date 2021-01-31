using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ConsultingMatch.DataLayer;
using ConsultingMatch.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Clients
{
    public class List
    {
        public class Query:IRequest<List<Client>>{}
        public class Handler : IRequestHandler<Query, List<Client>>
        {
            private readonly DeveloperDbContext _context;
            public Handler(DeveloperDbContext context)
            {
                _context=context;
            }
            public async Task<List<Client>> Handle(Query request, CancellationToken cancellationToken)
            {
               var clients=await _context.Clients.ToListAsync();

               return clients;
            }
        }
    }
}