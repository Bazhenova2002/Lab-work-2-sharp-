using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Bazhenovа
{
    class RegularSquarePrism : Square  // наледование
    {
        public readonly double height;  // член класса высота

        public double GetPrismDiagonal()  // метод вычисления диагонали призмы
        {
            return Math.Sqrt(Math.Pow(GetDiagonal(), 2) + Math.Pow(height, 2));
        }

        public double GetArea(RegularSquarePrism prism)  // перегрузка метода вычисения площади 
        {
            return (Math.Pow(prism.side, 2) * 2) + (prism.side * prism.height * 4);
        }

        public double GetPerimeter(RegularSquarePrism prism)  // перегрузка метода вычисления периметра
        {
            return (prism.side * 8) + (prism.height * 4);
        }

        public double GetPrismVolume()  // метод вычисления объема призмы
        {
            return Math.Pow(side, 2) * height;
        }

        public string GetInformationAboutTheFigure(RegularSquarePrism prism)  // перегрузка метода вывода информации о фигуре
        {
            double volume = prism.GetPrismVolume();

            return "Сторона основания призмы: " + prism.side + "\nДиагональ призмы: " + prism.GetPrismDiagonal()
                + "\nДиагональ основания призмы: " + prism.GetDiagonal() + "\nПериметр призмы: " + prism.GetPerimeter(prism)
                + "\nПлощадь поверхности призмы: " + prism.GetArea(prism) + "\nОбъем призмы: " + prism.GetPrismVolume();
        }

        public RegularSquarePrism(double side, double height) : base(side)  // конструктор 
        {
            this.height = height;
        }
    }
}
