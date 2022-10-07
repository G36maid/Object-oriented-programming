using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QUIZ3.Triangle;

namespace QUIZ3
{

    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            while (true)
            {
                string str;
                Console.WriteLine("請輸入三個點的平面座標，並計算其特性");
                Console.WriteLine("(x1,y1)=");
                str = Console.ReadLine();
                tri.Px[1] = double.Parse(str);
                str = Console.ReadLine();
                tri.Py[1] = double.Parse(str);

                Console.WriteLine("(x2,y2)=");
                str = Console.ReadLine();
                tri.Px[2] = double.Parse(str);
                str = Console.ReadLine();
                tri.Py[2] = double.Parse(str);

                Console.WriteLine("(x3,y3)=");
                str = Console.ReadLine();
                tri.Px[3] = double.Parse(str);
                str = Console.ReadLine();
                tri.Py[3] = double.Parse(str);

                if (!tri.IsValid())
                {
                    Console.WriteLine("這三點不能組成三角形！");

                }
                else
                {
                    Console.WriteLine("Perimeter=");
                    Console.WriteLine(tri.Perimeter());
                    Console.WriteLine("Area=");
                    Console.WriteLine(tri.Area());
                    Console.WriteLine("Radius Of Circumcircle=");
                    Console.WriteLine(tri.RadiusOfCircumcircle());

                    if (tri.IsRight())
                    {
                        Console.WriteLine("是直角三角形!");
                    }
                    else
                    {
                        Console.WriteLine("非直角三角形!");
                    }
                }
                Console.WriteLine("Again?");
                string st = Console.ReadLine();
                if (st == "n")
                {
                    break;
                }
                else if (st == "y")
                {
                    continue;
                }



            }
            Console.ReadKey();







        }
    }
}
