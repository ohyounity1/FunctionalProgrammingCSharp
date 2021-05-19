using System;
using Xunit;

namespace Framework.FP.Core.Testing
{
	using static Framework.FP.Core.Swap.FP;

	public class SwapTest
	{
		[Fact]
		public void Test()
		{
			var arg0 = 5;
			var arg1 = 10;

			Func<int, int, bool> original = (_0, _1) => { Assert.Equal(_0, arg1); Assert.Equal(_1, arg0);  return true; };

			var result = original.Swap()(5, 10);
			Assert.True(result);
		}
	}
}
