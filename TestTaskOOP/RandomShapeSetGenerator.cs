using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskOOP
{  // класс RandomShapeSetGenerator предназначен для генерации случайного набора геометрических фигур и работы с ним
    public class RandomShapeSetGenerator
    
    {
    //инициализация объекта генератора псевдослучайных чисел
     private  static Random random  = new Random();
     // список в котором будет храниться набор фигур
     private List<Shape> shapeList;

        public RandomShapeSetGenerator()
        {
            this.shapeList = new List<Shape>();
        }
        /*
          Метод генерирует случайный набор фигур(1-20 фигур) и добавляет их в shapeList.
          (я думаю диапазона от 1 до 21 для нашей программы будет достаточно)
        */
        public void genShapeSet()
        {
            
            int quantityOfShapes = random.Next(1,21);

            Console.WriteLine(quantityOfShapes);

            for (int i = 0; i < quantityOfShapes; i++)
            {
                Shape newShape = getRandomSnape();
                shapeList.Add(newShape);
            }
        }
        //выводит в консоль  информацию про все фигуры из shapeList
        public void showShapeSet()
        {
            foreach (Shape item in shapeList)
            {
                item.draw();
            }

        }
        //метод возвращает новый объект геометрической фигуры которая выбирается псевдослучайным образом
        private static Shape getRandomSnape() {
           
            int value = random.Next(1,5);

            Console.WriteLine("value: " + value);

            if (value == 1) return new Square("black",5);

            else if (value == 2) return new Circle("red",8.6f);

            else if (value == 3) return new Triangle("green",5.5f,6.9f) ;

            return new Trapezium("yellow",5,10,5) ;
         

        }
    }
}
