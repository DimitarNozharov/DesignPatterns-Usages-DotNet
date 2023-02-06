using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourPatterns.StatePattern
{
	// The base State class declares methods that all conrecte State should implement
	// Also it provides a reference to the Context object associated with the state.
	// This reference can be used by States to transition the Context to another State
	public abstract class State
	{
		protected Context _context;
		public void SetContext(Context context)
		{
			_context = context;
		}

		public abstract void Handle1();
		public abstract void Handle2();
	}
}
