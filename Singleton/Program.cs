using NUnit.Framework;

namespace Singleton
{
	[TestFixture]
	internal class Program
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

		//TODO: add test for the multithreading part
	}


}
