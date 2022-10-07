using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz4
{
    class Triangle
    {
        public double[] XCoord = new double[3];
        public double[] YCoord = new double[3];
        public const double Tol= 1e-10;
        private void SideLengths(double[] side)
        {
            //side[0] = Math.Sqrt((XCoord[0] - XCoord[1]) * (XCoord[0] - XCoord[1]) + (YCoord[0] - YCoord[1]) * (YCoord[0] - YCoord[1]));
            //side[1] = Math.Sqrt((XCoord[1] - XCoord[2]) * (XCoord[1] - XCoord[2]) + (YCoord[1] - YCoord[2]) * (YCoord[1] - YCoord[2]));
            //side[2] = Math.Sqrt((XCoord[2] - XCoord[0]) * (XCoord[2] - XCoord[0]) + (YCoord[2] - YCoord[0]) * (YCoord[2] - YCoord[0]));
            for (int i=0;i<3;i++)
            {
                side[i] = Math.Sqrt((XCoord[i] - XCoord[(i+1)%3]) * (XCoord[i] - XCoord[(i + 1) % 3]) + (YCoord[i] - YCoord[(i + 1) % 3]) * (YCoord[i] - YCoord[(i + 1) % 3]));
            }
        }
        public double Perimeter()
        {
            double[] s = new double[3];
            SideLengths(s);
            double sum = 0;

            foreach (var element in s)
                sum += element;

            return (sum);
        }
        public double Area()
        {
            double[] s = new double[3];
            SideLengths(s);
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - s[0]) * (p - s[1]) * (p - s[2]));
        }
        public bool isValid()
        {
            double[] s = new double[3];
            SideLengths(s);
            if ((Math.Abs(s[0] + s[1] - s[2]) < Tol) || (Math.Abs(s[1] + s[2] - s[0]) < Tol) || (Math.Abs(s[2] + s[0] - s[1]) < Tol))
                return false;
            return true;
        }
        public bool isRight()
        {
            double[] s = new double[3];
            SideLengths(s);
            if ((Math.Abs(s[0] * s[0] + s[1] * s[1] - s[2] * s[2]) < Tol) || (Math.Abs(s[1] * s[1] + s[2] * s[2] - s[0] * s[0]) < Tol) || (Math.Abs(s[0] * s[0] + s[2] * s[2] - s[1] * s[1]) < Tol))
                return true;
            return false;
        }
        public double RadiusOfCircumcircle()
        {
            double[] s = new double[3];
            SideLengths(s);
            double CosAlpha = (s[1] * s[1] + s[2] * s[2] - s[0] * s[0]) / (2 * s[1] * s[2]);
            double SinAlpha = Math.Sqrt(1 - CosAlpha * CosAlpha);
            return 0.5 * s[0] / SinAlpha;
        }
    }
}
