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
	/// 4. Initialize it only if it hasn't been initialized (checking if instance is null) and using the lock in case of multithreading. (can be implemented via Lazy<>)
	///
	/// Usages:	Logging, driver objects, caching and thread pool, database connections.
	/// </summary>
	public sealed class MySingleton
	{
		private static MySingleton _instance;
		private static readonly object _locker = new object();

		//For testing
		public string Text { get; set; }

		//Private parameterless constructor to not be able to call from outside
		private MySingleton() { }

		public static MySingleton Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_locker)
					{
						if (_instance == null)
							_instance = new MySingleton();
					}
				}

				return _instance;
			}
		}
		 
	}
}
