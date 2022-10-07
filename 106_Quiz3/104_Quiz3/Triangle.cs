using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz3
{
    class Triangle
    {
        public double Point1X;
        public double Point1Y;
        public double Point2X;
        public double Point2Y;
        public double Point3X;
        public double Point3Y;

        private double SideLength(double X1, double Y1, double X2, double Y2)
        {
            return Math.Sqrt((X1 - X2) * (X1 - X2) + (Y1 - Y2) * (Y1 - Y2));
        }
        public double Perimeter()
        {

            double s1 = SideLength(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = SideLength(Point2X, Point2Y, Point3X, Point3Y);
            double s3 = SideLength(Point3X, Point3Y, Point1X, Point1Y);

            return (s1 + s2 + s3);
        }
        public double Area()
        {
            double s1 = SideLength(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = SideLength(Point2X, Point2Y, Point3X, Point3Y);
            double s3 = SideLength(Point3X, Point3Y, Point1X, Point1Y);
            double s = (s1 + s2 + s3) / 2;
            return Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3));
        }
        public bool isValid()
        {
            double s1 = SideLength(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = SideLength(Point2X, Point2Y, Point3X, Point3Y);
            double s3 = SideLength(Point3X, Point3Y, Point1X, Point1Y);
            if ((s1 + s2 <= s3) || (s2 + s3 <= s1) || (s1 + s3 <= s2))
                return false;
            return true;
        }
        public bool isRight()
        {
            double s1 = SideLength(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = SideLength(Point2X, Point2Y, Point3X, Point3Y);
            double s3 = SideLength(Point3X, Point3Y, Point1X, Point1Y);
            if ((s1 * s1 + s2 * s2 - s3 * s3 < 1e-10) || (s2 * s2 + s3 * s3 - s1 * s1 < 1e-10) || (s1 * s1 + s3 * s3 - s2 * s2 < 1e-10))
                return true;
            return false;
        }
        public double RadiusOfCircumcircle()
        {
            double s1 = SideLength(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = SideLength(Point2X, Point2Y, Point3X, Point3Y);
            double s3 = SideLength(Point3X, Point3Y, Point1X, Point1Y);
            double CosAlpha = (s2 * s2 + s3 * s3 - s1 * s1) / (2 * s2 * s3);
            double SinAlpha = Math.Sqrt(1 - CosAlpha * CosAlpha);
            return 0.5 * s1 / SinAlpha;
        }

    }
}
