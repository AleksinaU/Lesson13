using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("проезд Оптимистов", 12000, 12000, 6000);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("проезд Оптимистов", 12000, 12000, 6000 , 1);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
