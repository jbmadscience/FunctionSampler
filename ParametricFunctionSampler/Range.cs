using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricFunctionSampler
{
	public static class Range
	{
		public static IEnumerable<double> Sample(double x1, double x2, int count)
		{
			Order(ref x1, ref x2);

			var dx = (x2 - x1) / count;
			for (var i = 0; i < count; i++)
			{
				yield return x1 + i * dx;
			}
		}

		public static IEnumerable<double> Sample(double x1, double x2, double dx)
		{
			var count = (int)Math.Floor(Math.Abs((x2 - x1) / dx));

			return Sample(x1, x2, count);
		}

		private static void Order(ref double a, ref double b)
		{
			if (b < a) Swap(ref a, ref b);
		}

		private static void Swap<T>(ref T a, ref T b)
		{
			var t = a;
			a = b;
			b = t;
		}
	}
}
