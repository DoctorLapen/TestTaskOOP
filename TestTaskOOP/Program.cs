﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomShapeSetGenerator generator = new RandomShapeSetGenerator();

            generator.genShapeSet();

            generator.showShapeSet();

            Console.ReadKey();
        }
    }
}
