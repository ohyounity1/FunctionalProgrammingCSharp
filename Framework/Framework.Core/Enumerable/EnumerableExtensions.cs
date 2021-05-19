using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Core.Enumerable
{
	public static class EnumerableExtensions
	{
		public static IEnumerable<T> Quicksort<T>(this IEnumerable<T> source, Comparison<T> comparer)
		{
			if(source.Count() < 2)
				return source;

			(IEnumerable<T> left, IEnumerable<T> right, T pivotElement) Partition(IEnumerable<T> enumerable)
			{
				var asArray = enumerable.ToArray();

				var random = new Random(Guid.NewGuid().GetHashCode());
				var randomIndex = random.Next(0, asArray.Length);

				var pivotElement = asArray[randomIndex];

				var left = asArray.Where((item) => comparer(item, pivotElement) == -1);
				var right = asArray.Where((item) => comparer(item, pivotElement) == 1);

				return (left, right, pivotElement);
			}

			(var left, var right, var pivotElement) = Partition(source);

			var sortedLeft = Quicksort(left, comparer).ToList();
			sortedLeft.Add(pivotElement);
			var sortedRight = Quicksort(right, comparer);

			sortedLeft.AddRange(sortedRight);

			return sortedLeft;
		}
	}
}
