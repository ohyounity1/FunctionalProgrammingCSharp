using Framework.Core.Enumerable;
using System;
using System.Linq;
using Xunit;

namespace Framework.Core.Testing
{
	public class Quicksort
	{
		[Fact]
		public void TestSize1()
		{
			var array = new[] { 1 };

			var sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
		}

		[Fact]
		public void TestSize2()
		{
			var array = new[] { 1, 5 };

			var sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);

			array = new[] { 5, 1 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
		}

		[Fact]
		public void TestSize3()
		{
			var array = new[] { 1, 5, 13 };

			var sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);

			array = new[] { 1, 13, 5 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);

			array = new[] { 5, 1, 13 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);

			array = new[] { 5, 13, 1 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);

			array = new[] { 13, 1, 5 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);

			array = new[] { 13, 5, 1 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);
		}

		[Fact]
		public void TestSize4()
		{
			var array = new[] { 1, 5, 13, 21 };

			var sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);
			Assert.True(sorted[3] == 21);

			array = new[] { 1, 5, 21, 13 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);
			Assert.True(sorted[3] == 21);

			array = new[] { 1, 21, 5, 13 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);
			Assert.True(sorted[3] == 21);

			array = new[] { 21, 1, 5, 13 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);
			Assert.True(sorted[3] == 21);

			array = new[] { 1, 13, 5, 21 };
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);
			Assert.True(sorted[3] == 21);

			array = new[] { 13, 1, 5, 21};
			sorted = array.Quicksort((i, j) => i.CompareTo(j)).ToArray();

			Assert.True(sorted[0] == 1);
			Assert.True(sorted[1] == 5);
			Assert.True(sorted[2] == 13);
			Assert.True(sorted[3] == 21);
		}
	}
}
