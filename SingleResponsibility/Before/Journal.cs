using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Before
{
    internal class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        //holding entries responsibility
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; //memento
        }

        //holding entries responsibility
        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //persistence responsibility
        public void Save(string fileName)
        {
            File.WriteAllText(fileName, ToString());

        }

        //persistence responsibility
        public static Journal Load(string fileName)
        {
            //some code
            return new Journal();
        }

        public void Load(Uri uri)
        {
            //some code
        }
    }
}
