using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Bazhenovа
{
    class Square  // класс квадрат
    {
        public readonly double side;  // чен класса - длинна стороны 
        
        public double GetDiagonal()  // метод вычисления диагонали 
        {
            return Math.Sqrt(2) * side;
        }

        public double GetPerimeter()  // метод вычисления периметра
        {
            return 4 * side;
        }

        public double GetArea()  // метод вычисления площади
        {
            return Math.Pow(side, 2);
        }

        public string GetInformationAboutTheFigure(Square square)  // метод вывода информации о фигуре
        {
            return "Сторона квадрата: " + square.side + '\n' + "Диагональ квадрата: " + square.GetDiagonal()
                + '\n' + "Периметр квадрата: " + square.GetPerimeter() + '\n' + "Площадь квадрата: " + square.GetArea();
        }

        public Square(double side)  // кнструктор класса (модификатор readonly: мы сможем задать переменной side ей значение только тут, а дальше только считывать)
        {
            this.side = side;
        }
    }
}