using System;

namespace Framework.FP.Core
{
	namespace Swap
	{
		public static class FP
		{
			public static Func<Arg1, Arg0, Ret> Swap<Arg0, Arg1, Ret>(this Func<Arg0, Arg1, Ret> original)
				=> (arg0, arg1) => original(arg1, arg0);
		}
	}

}
