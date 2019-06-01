using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{ //класс Triangle представляет прямоугольный треугольник 
    class Triangle:Shape
    {  /*
         Поля доступны толко для чтения,
         потому что данные в класах фигур только инициализируеться в конструкторе клаcса,а потом не изменяються
         более простой аналог геттеров
        */
        
        // поля leg1 и leg2 катеты
        public readonly float leg1;
        public readonly float leg2;

        public Triangle(string color,float leg1,float leg2):base(color)
        {
            this.leg1 = leg1;
            this.leg2 = leg2;
        }
        
       //  Реализация абстрактного метода getArea который возвращает площадь прямоугольного триугольника.
       
        public override float getArea()
        {
            return 0.5f * leg1 * leg2;
        }

        //Реализация абстрактного метода draw  который выводить информацию об объекте в консоль.
        public override void draw()
        {
            Console.WriteLine("Shape : Triangle  color : {0}   leg1 : {1:f2}  leg2 : {2:f2} hypotenuse : {3:f2} area : {4:f2}",
                color, leg1,leg2, getHypotenuse(), getArea());
        }
        // метод возвращает длину гипотенузы по теореме Пифагора
        public float getHypotenuse()
        {
            return  (float)  Math.Sqrt( (leg1*leg1) + (leg2*leg2));
        }
    }
}
