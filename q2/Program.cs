using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars c1 = new Cars();
            c1.Make = "Toyota";
            c1.Model = "corolla";
            c1.Engine = 1.7;
            c1.Speed = 0;

            Cars c2 = new Cars();
            c2.Make = "Ford";
            c2.Model = "Focus";
            c2.Engine = 1.1;
            c2.Speed = 0;

            Console.WriteLine($"car 1 \n Make:{c1.Make} Model:{c1.Model} Engine:{c1.Engine} Speed:{c1.Speed}\n");
            Console.WriteLine($"car 2 \n Make:{c2.Make} Model:{c2.Model} Engine:{c2.Engine} Speed:{c2.Speed}");

           
        }
    }
}
