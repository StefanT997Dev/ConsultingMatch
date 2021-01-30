using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultingMatch.Models
{
	public class Consulting
	{
		Client client;
		Consultant consulant;

		public Client Client { get => client; set => client = value; }
		public Consultant Consulant { get => consulant; set => consulant = value; }
	}
}
