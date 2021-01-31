using System.Threading;
using System.Threading.Tasks;
using ConsultingMatch.DataLayer;
using ConsultingMatch.Models;
using MediatR;

namespace Application.Clients
{
    public class Details
    {
        public class Query:IRequest<Client>
        {
            public int Id{get;set;}
        }
        public class Handler : IRequestHandler<Query, Client>
        {
            private readonly DeveloperDbContext _context;
            public Handler(DeveloperDbContext context)
            {
                _context=context;
            }

            public async Task<Client> Handle(Query request, CancellationToken cancellationToken)
            {
                var client = await _context.Clients.FindAsync(request.Id);

                return client; 
            }
        }
    }
}