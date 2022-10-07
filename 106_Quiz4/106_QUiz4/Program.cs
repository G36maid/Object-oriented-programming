using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tri = new Triangle();
            string[] tokens;
            while (true)
            {
                Console.WriteLine("請依序輸入三角形的三個頂點");
                for (int i = 0; i <= 2; i++)
                {
                    Console.Write("(x" + (i + 1).ToString() + ", y" + (i + 1).ToString()+ ")= ");
                    tokens = Console.ReadLine().Split();
                    tri.XCoord[i] = Double.Parse(tokens[0]);
                    tri.YCoord[i] = Double.Parse(tokens[1]);
                }
                if (!tri.isValid())
                    Console.WriteLine("Not a Triangle, Please Input the new coordinates!");
                else
                {
                    Console.WriteLine("Perimeter=" + tri.Perimeter().ToString());
                    Console.WriteLine("Area=" + tri.Area().ToString());
                    Console.WriteLine("Radius of Circumcircle=" + tri.RadiusOfCircumcircle().ToString());
                    if (tri.isRight())
                        Console.WriteLine("This is a right triangle!");
                }
                Console.Write("Again?  ");
                String check = Console.ReadLine();
                if ((check != "y") && (check != "Y"))
                    break;
            }
            Console.WriteLine("End of Program!");
            Console.ReadKey();
        }
    }

}
