using System;
using System.Drawing;

namespace Ufo
{
    class MoveCalculator
    {
        public static double GetReachedAccuracy(Input data, int members)
        {
            var coeff = GetTiltAngle(data.Start, data.End, members);
            var currentPoint = data.Start;
            double distance = GetDistance(data.Start, data.End);

            var sin = MathFunctions.Sin(coeff, members);
            var cos = MathFunctions.Cos(coeff, members);

            while(true)
            {
                currentPoint.X += (float)(data.Step * sin);
                currentPoint.Y += (float)(data.Step * cos);

                if (distance <= GetDistance(currentPoint, data.End))
                    break;
                distance = GetDistance(currentPoint, data.End);
            }
            return distance;
        }

        public static int GetMembersToAccuracy(Input data, double accuracy, int maxIteration = 100)
        {
            var members = 1;
            while (GetReachedAccuracy(data, members) > accuracy)
            {
                if (members == maxIteration)
                    return 0;
                members++;
            }
            return members;
        }

        public static double GetDistance(PointF first, PointF second) =>
            Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));

        public static double GetTiltAngle(PointF start, PointF end, int members)
        {
            var dx = end.X - start.X;
            var dy = end.Y - start.Y;

            var coeff = dy / dx <= 1 ?
                MathFunctions.ArcTan(dy / dx, members)
                :Math.PI / 2 - MathFunctions.ArcTan(dx / dy, members);

            if ((dx > 0 && dy < 0) || (dx < 0 && dy > 0))
                coeff += Math.PI;

            return coeff;
        }
    }
}
