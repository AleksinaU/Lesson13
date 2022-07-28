using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    sealed class MultiBuilding : Building
    {
        int floor;
        int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < 0)
                    floor = 0;
                else
                    floor = value;
            }
        }

        public MultiBuilding(string address, double lenght, double width, double height, int floor)
        :base (address, lenght, width, height)
        {
            this.Floor = floor; 
        }
        public string Print()
        {
            string result = base.Print();
            result += $" {floor}";
            return result;
        }

    }
}
