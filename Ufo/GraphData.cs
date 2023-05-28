using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ufo
{
    class GraphData
    {
        public readonly double MinRadius;
        public readonly double MaxRadius;
        public readonly double Step;
        public readonly double[] Values;

        public GraphData(double minRadius, double maxRadius, double step)
        {
            MinRadius = minRadius;
            MaxRadius = maxRadius;
            Step = step;

            var values = new List<double>();
            for (double i = MinRadius; i < MaxRadius; i += Step)
            {
                values.Add(i);
            }

            Values = values.ToArray();
        }
    }
}
