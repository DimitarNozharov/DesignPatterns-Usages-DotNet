using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Exercises.CodeBuilder
{
	public class CodeBuilder
	{
		private readonly IList<Field> Fields = new List<Field>();
		private StringBuilder sb = new StringBuilder();
		
		public string ClassName { get; private set; }

		public CodeBuilder(string className)
		{
			ClassName = className;
		}

		public CodeBuilder AddField(string name, string type)
		{
			var field = new Field() { Name = name, Type = type };
			Fields.Add(field);
			return this;
		}

		public override string ToString()
		{
			if (!string.IsNullOrWhiteSpace(ClassName))
			{
				sb.AppendLine($"public class {ClassName}");
				sb.AppendLine("{");
				foreach (var field in Fields)
				{
					sb.AppendLine(field.ToString());
				}
				sb.AppendLine("}");
			}

			return sb.ToString();
		}
	}
}
