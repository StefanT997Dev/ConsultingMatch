using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultingMatch.Models
{
	public class Client:User
	{
		private List<Consultant> listOfConsultants;
		public ServiceType ServiceType { get; set; }
		public List<Consultant> ListOfConsultants { get => listOfConsultants; set => listOfConsultants = value; }
	}
}
