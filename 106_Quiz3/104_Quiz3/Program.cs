using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens;
            Triangle tri=new Triangle();
            while (true)
            {
                Console.WriteLine("請輸入三角形的三個頂點座標，並計算其特性");
                Console.Write("(x1,y1)= ");
                tokens = Console.ReadLine().Split();
                tri.Point1X = Double.Parse(tokens[0]);
                tri.Point1Y = Double.Parse(tokens[1]);
                Console.Write("(x2,y2)= ");
                tokens = Console.ReadLine().Split();
                tri.Point2X = Double.Parse(tokens[0]);
                tri.Point2Y = Double.Parse(tokens[1]);
                Console.Write("(x3,y3)= ");
                tokens = Console.ReadLine().Split();
                tri.Point3X = Double.Parse(tokens[0]);
                tri.Point3Y = Double.Parse(tokens[1]);

                if (!tri.isValid())
                {
                    Console.WriteLine("這三點不能組成三角形!");
                }
                else
                {
                    Console.WriteLine("Perimeter=" + tri.Perimeter().ToString());
                    Console.WriteLine("Area=" + tri.Area().ToString());
                    Console.WriteLine("Radius of Circumcircle=" + tri.RadiusOfCircumcircle().ToString());
                    if (tri.isRight())
                        Console.WriteLine("直角三角形!");
                    else
                        Console.WriteLine("非直角三角形!");
                }
                Console.WriteLine("Again?  ");
                String check = Console.ReadLine();
                if ((check != "y")&&(check!="Y"))
                    break;
            }
            Console.WriteLine("End of Program!");
            Console.ReadKey();
        }
    }

}
