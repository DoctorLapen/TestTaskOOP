using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    class Trapezium:Snape
    {
        public readonly float baseA;
        public readonly float baseB;
        public readonly float height;
        public Trapezium(string color, float baseA, float baseB, float height) : base(color)
        {
            this.baseA = baseA;
            this.baseB = baseB;
            this.height = height;
        }
        public override void draw()
        {
            Console.WriteLine("Snape:Triangle color :{0} baseA : {1}  baseB: {2} height: {3} area : {4}", color, baseA, baseB, height, getArea());
        }

        public override float getArea() {
            return (baseA + baseB) / 2 * height;
        }
    }
}
