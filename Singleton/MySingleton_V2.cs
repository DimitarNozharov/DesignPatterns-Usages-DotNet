using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	/// <summary>
	/// Singleton is a creational design pattern that guarantee to create only 1 object from the class for the whole application.
	/// 1.It should be sealed to not be able to inherited from
	/// 2.Must have private constructor to not be able to create instance from outside via the ctor
	/// 3.Should have a static instance of the class to hold the instance
	/// 4. Initialize it only if it hasn't been initialized usign Lazy<T>.
	/// </summary>
	public sealed class MySingleton_V2
	{
		private static readonly Lazy<MySingleton_V2> _instance = 
			new Lazy<MySingleton_V2>(() => new MySingleton_V2());
		
		private MySingleton_V2() { }

		public static MySingleton_V2 Instance => _instance.Value;

		//For testing
		public string Text { get; set; }
	}
}
