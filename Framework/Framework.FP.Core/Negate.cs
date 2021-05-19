using System;

namespace Framework.FP.Core
{
	namespace Negate
	{
		public static class FP
		{
			public static Predicate<TArg> Negate<TArg>(this Predicate<TArg> original)
				=> (arg) => !original(arg);
		}

	}
}
