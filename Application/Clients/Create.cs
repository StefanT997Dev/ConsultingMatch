using System;
using System.Threading;
using System.Threading.Tasks;
using ConsultingMatch.DataLayer;
using ConsultingMatch.Models;
using MediatR;

namespace Application.Clients

{
    public class Create
    {
        public class Command:IRequest
        {
            public int Id { get ; set; }
		    public string Name { get; set; }
		    public string Surname { get; set; }
		    public string Email { get; set; }
		    public Country Country { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DeveloperDbContext _context;

            public Handler(DeveloperDbContext context)
            {
                _context=context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var client=new Client
                {
                    Name=request.Name
                };
                
                _context.Clients.Add(client);
                var success =await _context.SaveChangesAsync()>0;

                if(success) return Unit.Value;
                throw new Exception("Problem saving changes");
            }
        }
    }
}