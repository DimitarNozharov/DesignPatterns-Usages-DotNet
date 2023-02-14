using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Exercises.CodeBuilder
{
	public class Field
	{
		public string Name { get; set; }
		public string Type { get; set; } //TODO some validation could be added
		private const int spaceIdentation = 2;

		public override string ToString()
		{
			return $"{new string(' ', spaceIdentation)}public {Type} {Name};";
		}
	}
}
