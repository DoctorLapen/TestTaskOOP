using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{ /*
    Абстрактный клас Shape описывает общие методы для всех фигур.
    Он является предком для всех классов фигур
  */
    public abstract class Shape
    {  /*
         Поля доступны толко для чтения,
         потому что данные в класах фигур только инициализируеться в конструкторе клаcса,а потом не изменяються
         более простой аналог геттеров
        */

        public readonly string color;

        /* конструктор определен в абстрактном классе
         * для того что бы каждый раз вручную не инициализировать поле color в класcах потомках
         * а передавать значение через base
         */ 
        public Shape(string color) {
            this.color = color;
        }
     
      //Абстрактный метод draw выводить информацию об объекте в консоль.
       public  abstract void draw();
        
      //Абстрактный метод getArea возвращает площадь геометрической фигуры.
       
        public abstract float getArea();
    }
}
