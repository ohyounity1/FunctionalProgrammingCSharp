using System;
using Xunit;

namespace Framework.FP.Core.Testing
{
	using static Framework.FP.Core.Negate.FP;

	public class NegateTest
	{
		[Fact]
		public void TestTrue()
		{
			Predicate<int> truth = (i) => true;

			var resultOne = truth.Negate()(5);
			Assert.False(resultOne);
		}

		[Fact]
		public void TestFalse()
		{
			Predicate<int> unTruth = (i) => false;

			var resultOne = unTruth.Negate()(5);
			Assert.True(resultOne);
		}
	}
}
