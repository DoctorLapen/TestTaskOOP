using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    public abstract class Snape
    {
        public readonly string color;

        public Snape(string color) {
            this.color = color;
        }
       public  abstract void draw();
       public abstract float getArea();
    }
}
