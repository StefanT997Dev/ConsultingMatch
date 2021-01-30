using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultingMatch.Models
{
	public class ConsultingCategory
	{
		private int id;
		private string name;
		private int numberOfConsultants;

		public int Id { get => id; set => id = value; }
		[DisplayName("Category")]
		public string Name { get => name; set => name = value; }
		public int NumberOfConsultants { get => numberOfConsultants; set => numberOfConsultants = value; }
	}
}
