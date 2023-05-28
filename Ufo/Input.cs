using System.Drawing;

namespace Ufo
{
    class Input
    {
        public readonly PointF Start;
        public readonly PointF End;
        public readonly double Step;
        
        public Input(PointF start, PointF end, double step)
        {
            Start = start;
            End = end;
            Step = step;
        }
    }
}
