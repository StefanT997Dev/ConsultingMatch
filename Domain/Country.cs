using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultingMatch.Models
{
	public class Country
	{
		int id;
		string name;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
	}
}
