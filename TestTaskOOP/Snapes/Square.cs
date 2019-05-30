using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    class Square : Snape
    {
       public readonly float side;

        public Square(string color,float side):base(color)
        {
            this.side = side;
        }

        public override void draw()
        {
            Console.WriteLine("Snape:Square color :{0} side : {1} area : {2}",color,side,getArea());
        }

        public override float getArea()
        {
            return side * side;
        }



    }
}
