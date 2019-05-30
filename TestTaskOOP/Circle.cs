using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    class Circle:Snape
    {
        public readonly float radius;
        public Circle(string color, float radius) : base(color)
        {
            this.radius = radius;
        }
        public override void draw()
        {
            Console.WriteLine("Snape: Circle color :{0} side : {1} area : {2}", color, radius, getArea());
        }
        public override float getArea()
        {
            return 3.14f * (radius * radius);
        }
    }
}
