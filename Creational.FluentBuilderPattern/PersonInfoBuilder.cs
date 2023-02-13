using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FluentBuilderPattern
{
	//Foo : Bar<Foo>
	public class PersonInfoBuilder<SELF> 
		: PersonBuilder 
		where SELF : PersonInfoBuilder<SELF>
	{
		public SELF Called(string name)
		{
			person.Name = name;
			return (SELF)this;
		}
	}
}
