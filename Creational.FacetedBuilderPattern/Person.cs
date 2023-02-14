using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FacetedBuilderPattern
{
	public class Person
	{
		//Address info
		public string Name { get; set; }
		public string City { get; set; }
		public string Country { get; set; }

		//work
		public decimal Salary { get; set; }
		public string Position { get; set; }
		public int YearsExpirience { get; set; }

		public override string ToString()
		{
			return $"Address:\r\n{nameof(Name)} : {Name}, {nameof(City)}:{City}, {nameof(Country)} - {Country}\r\n" +
			$"Work:\r\n{nameof(Salary)} : {Salary}, {nameof(Position)} - {Position}, {nameof(YearsExpirience)} - {YearsExpirience}";
		}
	}
}
