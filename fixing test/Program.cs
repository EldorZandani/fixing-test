using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fixing_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int cal;
            int fat;
            int count = 0;
            int maxCal = 0;
            string nameOfMax = "";
            Console.WriteLine("please enter the name of the product");
            name = Console.ReadLine();
            while (name != "stop")
            {
                Console.WriteLine("please enter calories");
                cal = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter fat");
                fat = int.Parse(Console.ReadLine());
                Box c = new Box(name, cal, fat);
                if (c.IsHelthy())
                    count++;
                if (c.GetCal()>maxCal)
                {
                    maxCal = c.GetCal();
                    nameOfMax = c.GetName();
                }
                Console.WriteLine("please enter the name of the product");
                name = Console.ReadLine();
            }
            Console.WriteLine("Number of products that not bad for health" + count);
            Console.WriteLine(nameOfMax+ "has maximum calories");
        }
    }
}
