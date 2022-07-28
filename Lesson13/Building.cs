using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Building
    {
        string address;
        double lenght;
        double width;
        double height;
        double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                if (value < 0)
                    lenght = 0;
                else
                    lenght = value;
            }
        }
        double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }
        double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }
        public Building(string address, double lenght, double width, double height)
        {
            this.address = address;
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }
        public string Print()
        {
            return $"{address} {lenght} {width} {height}";
        }
    }
}
