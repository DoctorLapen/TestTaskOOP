using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    static class RandomSnapeGenerator
    {
        public static Snape getRandomSnape() {
            Random r = new Random();
            int value = r.Next(1,5);
            if (value == 1) return new Square("black",5);
            else if (value == 2) return new Circle("red",8.6f);
            else if (value == 3) return new Triangle("green",5.5f,6.9f) ;
            return new Trapezium("yellow",5,10,5) ;

        }
    }
}
