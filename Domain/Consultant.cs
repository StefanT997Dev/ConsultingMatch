using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultingMatch.Models
{
	public class Consultant:User
	{
		private ConsultingCategory consultingCategory;
		private double rating;
		private double priceForOneOnOneVideoSession;
		private List<Client> listOfClients;

		public ConsultingCategory ConsultingCategory { get => consultingCategory; set => consultingCategory = value; }
		public double Rating { get => rating; set => rating = value; }
		public double PriceForOneOnOneVideoSession { get => priceForOneOnOneVideoSession; set => priceForOneOnOneVideoSession = value; }
		public List<Client> ListOfClients { get => listOfClients; set => listOfClients = value; }
	}
}
