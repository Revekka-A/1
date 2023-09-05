using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Point
    {
        public double x, y;
        public Point(double xx, double yy) //конструктор для каждой вершины
        {
            x = Math.Round(xx, 2);
            y = Math.Round(yy, 2);
        }
    }
    public class Triangle
    {
        public Point a { get; set; }
        public Point b { get; set; }
        public Point c { get; set; }

        public Triangle(Point pa, Point pb, Point pc)   //Инициализация треугольника
        {
            try
            {
                a = pa;
                b = pb;
                c = pc;
                if ((pa.x == pb.x && pa.y == pb.y) || (pa.x == pc.x && pa.y == pc.y) || (pb.x == pc.x && pb.y == pc.y)) //Если точки лежат на одной прямой
                    throw new Exception("Такой треугольник не существует");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                Console.ReadKey();
                Environment.Exit(0);    //Прерывание выполнения программы
            }

        }
        public double Lenght(Point p1, Point p2)    //Вычисление длины стороны треугольника
        {
            return Math.Round(Math.Abs(Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y))), 2);
        }
        public void Show()      //Вывод треугольника
        {
            Console.WriteLine($"a = ({a.x};{a.y})\nb = ({b.x};{b.y})\nc = ({c.x};{c.y})");
        }
        public void Moving(double xx, double yy)    //Перемещение треугольника
        {
            a.x = a.x + xx; //меняем координаты вершины а
            a.y = a.y + yy;
            b.x = b.x + xx; //меняем координаты вершины b
            b.y = b.y + yy;
            c.x = c.x + xx; //меняем координаты вершины c
            c.y = c.y + yy;
        }
        public void SizeBig(double change)  //увеличение сторон треугольника
        {
            Point center = new Point(Math.Round((a.x + b.x + c.x) / 3, 2), Math.Round((a.y + b.y + c.y) / 3, 2)); //координаты для центральной точки
            a.x = Math.Round(center.x + (a.x - center.x) * change, 2);
            a.y = Math.Round(center.y + (a.y - center.y) * change, 2);
            b.x = Math.Round(center.x + (b.x - center.x) * change, 2);
            b.y = Math.Round(center.y + (b.y - center.y) * change, 2);
            c.x = Math.Round(center.x + (c.x - center.x) * change, 2);
            c.y = Math.Round(center.y + (c.y - center.y) * change, 2);
        }
        public void SizeSmall(double change)     //уменьшение треугольника
        {
            Point center = new Point(Math.Round((a.x + b.x + c.x) / 3, 2), Math.Round((a.y + b.y + c.y) / 3, 2)); //координаты для центральной точки
            if (change == 0)
            {
                return;
            }
            a.x = Math.Round(center.x + (a.x - center.x) / change, 2);
            a.y = Math.Round(center.y + (a.y - center.y) / change, 2);
            b.x = Math.Round(center.x + (b.x - center.x) / change, 2);
            b.y = Math.Round(center.y + (b.y - center.y) / change, 2);
            c.x = Math.Round(center.x + (c.x - center.x) / change, 2);
            c.y = Math.Round(center.y + (c.y - center.y) / change, 2);

        }
        private double NewX(Point p1, Point p2, double angle)    //Вычисление новой координаты точки при повороте по оси Х
        {
            return Math.Round((p1.x - p2.x) * Math.Cos(angle) - (p1.y - p2.y) * Math.Sin(angle) + p2.x, 2);
        }
        private double NewY(Point p1, Point p2, double angle)    //Вычисление новой координаты точки при повороте по оси 
        {

            return Math.Round((p1.x - p2.x) * Math.Sin(angle) + (p1.y - p2.y) * Math.Cos(angle) + p2.y, 2);
        }
        public void Rotation_Angle(double angle)    //вращение треугольника на заданный угол
        {
            Point center = new Point(Math.Round((a.x + b.x + c.x) / 3, 2), Math.Round((a.y + b.y + c.y) / 3, 2));
            a.x = NewX(a, center, angle); a.y = NewY(a, center, angle);
            b.x = NewX(b, center, angle); b.y = NewY(b, center, angle);
            c.x = NewX(c, center, angle); c.y = NewY(c, center, angle);
        }
    }

}
