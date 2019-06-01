using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{
    class Square : Shape
    {
        /*
         Поля доступны толко для чтения,
         потому что данные в класах фигур только инициализируеться в конструкторе клаcса,а потом не изменяються
         более простой аналог геттеров
        */
        public readonly float side;

        public Square(string color,float side):base(color)
        {
            this.side = side;
        }

        //Реализация абстрактного метода draw  который выводить информацию об объекте в консоль.
        public override void draw()
        {
            Console.WriteLine("Shape : Square color : {0}   side : {1:f2} area : {2:f2}", color,side,getArea());
        }
       
        /*
        Реализация абстрактного метода getArea который возвращает площадь квадрата.
        Без использования  метода из Math код становиться более читабельным
       */
        public override float getArea()
        {
            return side * side;
        }



    }
}
