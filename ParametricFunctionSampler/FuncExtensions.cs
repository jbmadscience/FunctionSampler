using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricFunctionSampler
{
	public static class FuncExtensions
	{
		public static IEnumerable<double> Sample(this Func<double, double> f, double a, double b, int count)
		{
			foreach (var x in Range.Sample(a, b, count))
			{
				yield return f(x);
			}
		}
	}
}
