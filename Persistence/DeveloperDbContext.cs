using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsultingMatch.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsultingMatch.DataLayer
{
	public class DeveloperDbContext : DbContext
	{
		public DeveloperDbContext(DbContextOptions<DeveloperDbContext> options) : base(options)
		{

		}
		public DbSet<Client> Clients { get; set; }
		public DbSet<Consultant> Consultants { get; set; }
	}
}
