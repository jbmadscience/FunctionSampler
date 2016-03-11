using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametricFunctionSampler
{
	public class ParametricEquation
	{
		public Func<double, double> X { get; private set; }
		public Func<double, double> Y { get; private set; }

		public ParametricEquation(Func<double, double> x, Func<double, double> y)
		{
			X = x;
			Y = y;
		}

		public static ParametricEquation Parabola => new ParametricEquation(t => t, t => t * t);
		public static ParametricEquation Circle => new ParametricEquation(Math.Cos, Math.Sin);

		public IEnumerable<double> SampleX(double a, double b, int count)
		{
			return X.Sample(a, b, count);
		}

		public IEnumerable<double> SampleY(double a, double b, int count)
		{
			return Y.Sample(a, b, count);
		}
	}
}
