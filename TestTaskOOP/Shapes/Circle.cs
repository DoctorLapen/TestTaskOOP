using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{  
    class Circle:Shape
    {   /*
         Поля доступны толко для чтения,
         потому что данные в класах фигур только инициализируеться в конструкторе клаcса,а потом не изменяються
         более простой аналог геттеров
        */
        public readonly float radius;
        public Circle(string color, float radius) : base(color)
        {
            this.radius = radius;
        }
        //Реализация абстрактного метода draw  который выводить информацию об объекте в консоль.
        public override void draw()
        {
            Console.WriteLine("Shape : Circle color : {0}   side : {1:f2} area : {2:f2}", color, radius, getArea());
        }
    
        /*
        Реализация абстрактного метода getArea который возвращает площадь круга.
        Без использования констант и методов из Math код становиться более читабельным
        */
        public override float getArea()
        {
            return 3.14f * (radius * radius);
        }
    }
}
