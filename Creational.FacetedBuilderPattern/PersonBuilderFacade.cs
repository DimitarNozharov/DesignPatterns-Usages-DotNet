using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FacetedBuilderPattern
{
	//the cliend should use the facade, so we need to expose the sub builder
	public class PersonBuilderFacade
	{
		//its important to be reference type instead of struct
		protected Person Person { get; set; } = new Person();

		public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);
		public PersonJobBuilder Work => new PersonJobBuilder(Person);

		//used for print the result when cast to Person implicitly
		public static implicit operator Person(PersonBuilderFacade builder)
		{
			return builder.Person;
		}

	}
}
