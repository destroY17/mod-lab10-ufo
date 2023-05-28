using ScottPlot;
using System.Drawing;
using System.Linq;

namespace Ufo
{
    class GraphBuilder
    {
        public static void SaveGraph(Size graphSize, Input data, double[] arguments, string filePath)
        {
            var plt = new Plot(graphSize.Width, graphSize.Height);
            plt.AddScatter(arguments, GetMembers(arguments, data));
            plt.XLabel("Accuracy");
            plt.YLabel("Number of members");
            plt.SaveFig(filePath);
        }

        private static double[] GetMembers(double[] x, Input data) =>
            x.Select(j => (double)MoveCalculator.GetMembersToAccuracy(data, j)).ToArray();
    }
}
