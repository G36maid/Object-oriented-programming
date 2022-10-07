using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ3
{
    class Triangle
    {
        public double Point1X;
        public double Point1Y;
        public double Point2X;
        public double Point2Y;
        public double Point3X;
        public double Point3Y;
        
        private double Side(double x1,double y1,double x2,double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

        }


        public bool IsValid()// 檢查三角形是否合法
        {
            double s1 = Side(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = Side(Point3X, Point3Y, Point2X, Point2Y);
            double s3 = Side(Point1X, Point1Y, Point3X, Point3Y);
            if (s1+s2<=s3 || s2+s3<=s1 || s1+s3<=s2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double Perimeter()// 計算周長
        {
            double s1 = Side(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = Side(Point3X, Point3Y, Point2X, Point2Y);
            double s3 = Side(Point1X, Point1Y, Point3X, Point3Y);
            return (s1 + s2 + s3);
        }
        public double Area()// 計算面積
        {
            double s1 = Side(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = Side(Point3X, Point3Y, Point2X, Point2Y);
            double s3 = Side(Point1X, Point1Y, Point3X, Point3Y);
            double s = (s1 + s2 + s3) / 2;
            return Math.Sqrt((s-s1) * (s-s2) * (s - s3) * s);
        }

        public double RadiusOfCircumcircle()// 計算外接圓半徑
        {
            double s1 = Side(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = Side(Point3X, Point3Y, Point2X, Point2Y);
            double s3 = Side(Point1X, Point1Y, Point3X, Point3Y);
            double cosA = (s1 * s1 + s2 * s2 - s3 * s3) / (2 * s1 * s2);
            double sinA = Math.Sqrt(1 - cosA * cosA);
            return s3/(2*sinA);

        }
        public bool IsRight()// 檢查三角形是否為直角
        {
            double s1 = Side(Point1X, Point1Y, Point2X, Point2Y);
            double s2 = Side(Point3X, Point3Y, Point2X, Point2Y);
            double s3 = Side(Point1X, Point1Y, Point3X, Point3Y);
            if(s1*s1+s2*s2-s3*s3<1e-10|| s1 * s1 + s3 * s3 - s2 * s2 < 1e-10|| s3 * s3 + s2 * s2 - s1 * s1 < 1e-10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
