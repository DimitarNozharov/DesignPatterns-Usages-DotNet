using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton
{
	[TestFixture]
	internal class StartUp
	{
		static void Main(string[] args)
		{
		}

		[Test]
		public void CheckIfSingletonCreatesOnly1Instance()
		{
			var obj1 = MySingleton.Instance;
			obj1.Text = "First instance";
			var obj2 = MySingleton.Instance;
			obj2.Text = "Second instance";

			Assert.IsTrue(obj1 == obj2, $"Both {obj1} and {obj2} are not pointing to the same address in the memory");
			Assert.AreEqual(obj1.Text, obj2.Text, $"Expected {nameof(obj1.Text)} values {obj1.Text} and {obj2.Text} to be the same.");
		}

		[Test]
		public void CheckIfSingletonCreatesOnly1Instance_V2()
		{
			var obj1 = MySingleton_V2.Instance;
			obj1.Text = "First instance";
			var obj2 = MySingleton_V2.Instance;
			obj2.Text = "Second instance";

			Assert.IsTrue(obj1 == obj2, $"Both {obj1} and {obj2} are not pointing to the same address in the memory");
			Assert.AreEqual(obj1.Text, obj2.Text, $"Expected {nameof(obj1.Text)} values {obj1.Text} and {obj2.Text} to be the same.");
		}

		[Test]
		public void CheckIfSingleInstanceIsCreatedInMultithreadingEnv()
		{
			var tasks = new List<Task<MySingleton>>();
			for (int i = 0; i < 100; i++)
			{
				tasks.Add(Task.Run(() =>
				{
					var obj = MySingleton.Instance;
					obj.Text = $"Test{i}";
					return obj;
				}));
			}

			Task.WhenAll(tasks);

			for (int i = 1; i < tasks.Count; i++)
			{
				Assert.IsTrue(tasks[0].Result == tasks[i].Result);
				Assert.AreEqual(tasks[0].Result.Text, tasks[i].Result.Text);

			}
		}
	}
}
