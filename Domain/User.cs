using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultingMatch.Models
{
	public class User
	{
		private int id;
		private string name;
		private string surname;
		private Country country;
		private string email;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public string Surname { get => surname; set => surname = value; }
		public string Email { get => email; set => email = value; }
		public Country Country { get => country; set => country = value; }
	}
}
