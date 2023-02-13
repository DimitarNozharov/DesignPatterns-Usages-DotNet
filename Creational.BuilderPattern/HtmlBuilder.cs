using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.BuilderPattern
{
	public class HtmlBuilder
	{
		private readonly string rootName;
		HtmlElement root = new HtmlElement();

		public HtmlBuilder(string rootName)
		{
			root.Name = rootName;
			this.rootName = rootName;
		}

		public void AddChild(string childName, string childText)
		{
			var e = new HtmlElement(childName, childText);
			root.Elements.Add(e);
		}

		public override string ToString()
		{
			return root.ToString();
		}

		public void Clear()
		{
			root = new HtmlElement() { Name = rootName };
		}
	}
}
