using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ConsultingMatch.DataLayer;
using ConsultingMatch.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Categories
{
    public class List
    {
        public class Query:IRequest<List<ConsultingCategory>>{}
        public class Handler : IRequestHandler<Query, List<ConsultingCategory>>
        {
            private readonly DeveloperDbContext _context;
            public Handler(DeveloperDbContext context)
            {
                _context=context;
            }

            public async Task<List<ConsultingCategory>> Handle(Query request, CancellationToken cancellationToken)
            {
               var categories=await _context.ConsultingCategory.ToListAsync();

               return categories;
            }
        }
    }
}