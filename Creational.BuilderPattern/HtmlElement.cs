using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.BuilderPattern
{
	public class HtmlElement
	{
		public string Name { get; set; }
		public string Text { get; set; }

		public IList<HtmlElement> Elements { get; set; } = new List<HtmlElement>();
		private const int indentSize = 2;

		public HtmlElement()
		{
		}

		public HtmlElement(string name, string text)
		{
			Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
			Text = text ?? throw new ArgumentNullException(paramName: nameof(text));
		}

		private string ToStringImpl(int indent)
		{
			var sb = new StringBuilder();
			var i = new string(' ', indentSize * indent);
			sb.AppendLine($"{i}<{Name}>");

			if(!String.IsNullOrWhiteSpace(Text)){
				sb.Append(new string(' ', indentSize * indent + 1));
				sb.AppendLine(Text);
			}

			foreach (var e in Elements)
			{
				sb.Append(e.ToStringImpl(indent + 1));
			}
			sb.AppendLine($"{i}</{Name}>");

			return sb.ToString();
		}

		public override string ToString()
		{
			return ToStringImpl(0);
		}
	}
}
