using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    class Triangle:Snape
    {
        private float leg1;
        private float leg2;

        public Triangle(string color,float leg1,float leg2):base(color)
        {
            this.leg1 = leg1;
            this.leg2 = leg2;
        }

        public override float getArea()
        {
            return 0.5f * leg1 * leg2;
        }
        public override void draw()
        {
            Console.WriteLine("Snape:Triangle color :{0} leg1 : {1}  leg2 : {2} hypotenuse : {3} area : {4}", color, leg1,leg2, getHypotenuse(), getArea());
        }
        public float getHypotenuse()
        {
            return  (float)  Math.Sqrt( (leg1*leg1) + (leg2*leg2));
        }
    }
}
