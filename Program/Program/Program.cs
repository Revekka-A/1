using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
//Описать класс, представляющий треугольник. Предусмотреть методы для созда
//ния объектов, перемещения на плоскости, изменения размеров и вращения на
//заданный угол.Описать свойства для получения состояния объекта.При неноз-
//можности построения треугольника выбрасывается исключение.
//Написать программу, демонстрирующую все разработанные элементы класса.
/*Lenght(pa, pb) > (Lenght(pc, pa) + Lenght(pb, pc)) || Lenght(pa, pc) > (Lenght(pa, pb) + Lenght(pb, pc)) ||
Lenght(pb, pc) > (Lenght(pa, pc) + Lenght(pa, pb)) ||*/

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double ax, ay, bx, by, cx, cy, xx, yy, remove, angle; // создание переменных
                Console.WriteLine("Программа по созданию треугольника\n\nВведите координаты для точки а:");
                ax = Convert.ToDouble(Console.ReadLine()); //ввод значения для точки а по оси Х
                ay = Convert.ToDouble(Console.ReadLine()); //ввод значения для точки а по оси У
                Point pa = new Point(ax, ay);       //Создание объекта Point для заполнения координат точки а
                Console.WriteLine("\nВведите координаты для точки b:");
                bx = Convert.ToDouble(Console.ReadLine());
                by = Convert.ToDouble(Console.ReadLine());
                Point pb = new Point(bx, by);        //Создание объекта Point для заполнения координат точки  b
                Console.WriteLine("\nВведите координаты для точки c:");
                cx = Convert.ToDouble(Console.ReadLine());
                cy = Convert.ToDouble(Console.ReadLine());
                Point pc = new Point(cx, cy);       //Создание объекта Point для заполнения координат точки  c
                Triangle triangle = new Triangle(pa, pb, pc);   //Создание треугольника
                Console.WriteLine("Треугольник создан:");
                triangle.Show();

                Console.WriteLine("\nВыберите нужную задачу:\n1 - Вывод координат треугольника\n2 - Перемещение треугольника");
                Console.WriteLine("3 - Изменение размера треугольника\n4 - Вращение треугольника на заданный угол");
                int choose;
                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        triangle.Show();
                        break;

                    case 2:
                        Console.WriteLine("\nПеремещение треугольника\nНа сколько переместить по оси Х");
                        xx = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("На сколько переместить по оси Y");
                        yy = Convert.ToDouble(Console.ReadLine());
                        triangle.Moving(xx, yy);
                        Console.WriteLine("Координаты треугольника изменены:");
                        triangle.Show();
                        break;

                    case 3:
                        Console.WriteLine("\nИзменение размера треугольника\nУвеличить треугольник - 1\nУменьшить треугольник - 2");
                        int operation;
                        operation = Convert.ToInt32(Console.ReadLine());
                        switch (operation)
                        {
                            case 1:
                                Console.WriteLine("Введите во сколько раз увеличить треугольник:");
                                remove = Convert.ToDouble(Console.ReadLine());
                                triangle.SizeBig(remove);
                                Console.WriteLine("Треугольник:");
                                triangle.Show();
                                break;
                            case 2:
                                Console.WriteLine("Введите во сколько раз уменьшить треугольник:");
                                remove = Convert.ToDouble(Console.ReadLine());
                                triangle.SizeSmall(remove);
                                Console.WriteLine("Треугольник:");
                                triangle.Show();
                                break;
                            default:
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nВращение треугольника на заданный угол\nНа сколько градусов повернуть треугольник:");
                        angle = Convert.ToDouble(Console.ReadLine());
                        triangle.Rotation_Angle(angle);
                        Console.WriteLine("Треугольник изменен:");
                        triangle.Show();
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Некоррекнтый ввод данных");
               
            }

            Console.ReadLine();
        }
    }
}