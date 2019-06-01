using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    class Trapezium:Shape
    {    /*
         Поля доступны толко для чтения,
         потому что данные в класах фигур только инициализируеться в конструкторе клаcса,а потом не изменяються
         более простой аналог геттеров
        */
        //поля baseA и baseB  поля трапеции
        public readonly float baseA;
        public readonly float baseB;

        //Высота трапеции
        public readonly float height;

        public Trapezium(string color, float baseA, float baseB, float height) : base(color)
        {
            this.baseA = baseA;
            this.baseB = baseB;
            this.height = height;
        }

        //Реализация абстрактного метода draw  который выводить информацию об объекте в консоль.
        public override void draw()
        {
            Console.WriteLine("Shape : Trapezium  color : {0}    baseA : {1:f2}  baseB : {2:f2} height : {3:f2} area : {4:f2}",
                color, baseA, baseB, height, getArea());
        }

        /*
       Реализация абстрактного метода getArea .
       Возвращает площадь трапеции.
       
      */
        public override float getArea() {
            return (baseA + baseB) / 2 * height;
        }
    }
}
