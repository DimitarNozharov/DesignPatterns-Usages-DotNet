using SingleResponsibility.After;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
	internal class Demo
	{
		public static void Main(string[] args)
		{
			var journal = new Before.Journal();
			journal.AddEntry("I cried today");
			journal.AddEntry("I ate a bug");
			Console.WriteLine(journal);

			var newJournal = new Journal();
			var pers = new Persistence();
			var fileName = @"c:\temp\Journal.txt";
			pers.SaveToFile(newJournal, fileName, true);

			var process = new Process();
			process.StartInfo = new ProcessStartInfo(fileName)
			{
				UseShellExecute = true
			};
			process.Start();
		}
	}
}
