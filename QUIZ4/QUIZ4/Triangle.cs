using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ3
{
    class Triangle
    {
        public double[] Px = { 0, 0, 0,0 };
        public double[] Py = { 0, 0, 0,0 };


        private double Side(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

        }


        public bool IsValid()// 檢查三角形是否合法
        {
            double[] s = { 0, 0, 0, 0,0};
            s[1] = Side(Px[1], Py[1], Px[2], Py[2]);
            s[2] = Side(Px[3], Py[3], Px[2], Py[2]);
            s[3] = Side(Px[1], Py[1], Px[3], Py[3]);
            s[4] = s[1] + s[2] + s[3];

            if (s[1] + s[2] <= s[3] || s[2] + s[3] <= s[1] || s[1] + s[3] <= s[2])
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
            double[] s = { 0, 0, 0, 0,0 };
            s[1] = Side(Px[1], Py[1], Px[2], Py[2]);
            s[2] = Side(Px[3], Py[3], Px[2], Py[2]);
            s[3] = Side(Px[1], Py[1], Px[3], Py[3]);
            s[4] = s[1] + s[2] + s[3];
            return s[4];
        }
        public double Area()// 計算面積
        {
            double[] s = { 0, 0, 0, 0,0 };
            s[1] = Side(Px[1], Py[1], Px[2], Py[2]);
            s[2] = Side(Px[3], Py[3], Px[2], Py[2]);
            s[3] = Side(Px[1], Py[1], Px[3], Py[3]);
            s[4] = s[1] + s[2] + s[3];
            s[4] = s[4] / 2;
            return Math.Sqrt((s[4] - s[1]) * (s[4] - s[2]) * (s[4] - s[3]) * s[4]);
        }

        public double RadiusOfCircumcircle()// 計算外接圓半徑
        {
            double[] s = { 0, 0, 0, 0,0 };
            s[1] = Side(Px[1], Py[1], Px[2], Py[2]);
            s[2] = Side(Px[3], Py[3], Px[2], Py[2]);
            s[3] = Side(Px[1], Py[1], Px[3], Py[3]);
            s[4] = s[1] + s[2] + s[3];
            double cosA = (s[1] * s[1] + s[2] * s[2] - s[3] * s[3]) / (2 * s[1] * s[2]);
            double sinA = Math.Sqrt(1 - cosA * cosA);
            return s[3] / (2 * sinA);

        }
        public bool IsRight()// 檢查三角形是否為直角
        {
            double[] s = { 0, 0, 0, 0,0 };
            s[1] = Side(Px[1], Py[1], Px[2], Py[2]);
            s[2] = Side(Px[3], Py[3], Px[2], Py[2]);
            s[3] = Side(Px[1], Py[1], Px[3], Py[3]);
            s[4] = s[1] + s[2] + s[3];
            if (s[1] * s[1] + s[2] * s[2] - s[3] * s[3] < 1e-10 || s[1] * s[1] + s[3] * s[3] - s[2] * s[2] < 1e-10 || s[3] * s[3] + s[2] * s[2] - s[1] * s[1] < 1e-10)
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
