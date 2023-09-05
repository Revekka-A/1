﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibraryVector;

namespace ConsoleApp1
{
    class Program
    {
        public class Vector
        {
            public double X { get; set; }   //создание автоматического свойства X, что обеспечивает приватность переменной, созданной этим свойством
            public double Y { get; set; }   //создание автоматического свойства Y, что обеспечивает приватность переменной, созданной этим свойством
            public double Z { get; set; }   //создание автоматического свойства Z, что обеспечивает приватность переменной, созданной этим свойством
            public double LEN { get; set; } //создание автоматического свойства LEN, что обеспечивает приватность переменной, созданной этим свойством
            static public Vector Sum(Vector c1, Vector c2)  //описание статического метода Sum, который возвращает новый объект, получившийся в результате сложения векторов
            {
                Vector VectNew = new Vector();  //создание нового вектора
                VectNew.X = c1.X + c2.X;    //установка значения X
                VectNew.Y = c1.Y + c2.Y;    //установка значения Y
                VectNew.Z = c1.Z + c2.Z;    //установка значения Z
                return VectNew; //передача полученного в результате работы метода нового вектора
            }
            static public Vector Subtruct(Vector c1, Vector c2) //описание метода Subtruct, который возвращает новый объект, получившийся в результате вычитания
            {
                Vector SubstructNew = new Vector(); //создание нового вектора
                SubstructNew.X = c1.X - c2.X;   //установка значения X
                SubstructNew.Y = c1.Y - c2.Y;   //установка значения Y
                SubstructNew.Z = c1.Z - c2.Z;   //установка значения Z
                return SubstructNew;    //передача полученного в результате работы метода нового вектора
            }
            static public void Length(ref Vector c1)    //описание метода Length, который устанавливает значение длины для вектора. Получает объект класса по ссылке и работает с этим объектом непосредственно, а потому ничего не возвращает
            {
                c1.LEN = Math.Sqrt(c1.X * c1.X + c1.Y * c1.Y + c1.Z * c1.Z);    //вычисление длины вектора и установка значения
            }
            static public double Cos(Vector c1, Vector c2)  //описание метода Cos, который расчитывает косинус между векторами и возвращет полученное значение в виде переменной типа double 
            {
                double a = Math.Sqrt(c1.X * c1.X + c1.Y * c1.Y + c1.Z * c1.Z);  //расчет длины первого вектора
                double b = Math.Sqrt(c2.X * c2.X + c2.Y * c2.Y + c2.Z * c2.Z);  //расчет длины второго вектора
                double Cos; //объявление переменной, в которую будет записываться ответ
                if (a == 0 || b == 0)   //при условии хотя бы одного вектора с нулевой длиной
                {
                    Cos = 0;    //косинус устанавливается нулевым по свойствам векторов
                }
                else   //если нулевых векторов нет, происходит расчет косинуса между векторами по формуле
                {
                    Cos = ((c1.X * c2.X) + (c1.Y * c2.Y) + (c1.Z * c2.Z)) / (a * b);
                }
                return Cos; //передача полученной в результате работы метода переменной
            }
            static public double Multiply(Vector c1, Vector c2) //описание метода Multiply, который расчитывает скалярное приозведение векторов и возвращает переменную типа double
            {
                double p = (c1.X * c2.X) + (c1.Y * c2.Y) + (c1.Z * c2.Z);   //расчет скалярного проихведения
                return p;   //передача полученной в результате работы метода переменной
            }
            static public void SetX(Vector c1)  //объявление метода, который проверяет правльность ввода X и ничего не возвращает, работая только с объектами класса напрямую
            {
                bool Correct = false;   //переменная для проверки. Если пользователь ввседет все правильно, то станет true
                double temp;    //переменная для временного хранения введенных пользователем данных
                do
                {
                    try
                    {
                        if (!double.TryParse(Console.ReadLine(), out temp)) //если преобразовать введенную пользователем строку к типу double невозможно 
                        {
                            throw new Exception("Некорректный ввод числового значения для оси X."); //создание нового объекта класса Exception (исключение)
                        }
                        Correct = true; //сработает только в том случае, если пользователь введет корректное число, обеспечит выход из цикла
                        c1.X = temp;    //свойству присваивается значение переменной temp, в которой уже лежит преобразованное к типу double значение
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);  //вывод сообщения об ошибке
                    }
                } while (!Correct); //повторять, пока Correct не станет true, т.е. пока пользователь не введет верное значение.
            }
            static public void SetY(Vector c1)  //объявление метода, который проверяет правльность ввода Y, аналогичен методу SetX
            {
                bool Correct = false;
                double temp;
                do
                {
                    try
                    {
                        if (!double.TryParse(Console.ReadLine(), out temp))
                        {
                            throw new Exception("Некорректный ввод числового значения для оси Y.");
                        }
                        Correct = true;
                        c1.Y = temp;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (!Correct);
            }
            static public void SetZ(Vector c1)  //объявление метода, который проверяет правльность ввода Z, аналогичен методу SetX
            {
                bool Correct = false;
                double temp;
                do
                {
                    try
                    {
                        if (!double.TryParse(Console.ReadLine(), out temp))
                        {
                            throw new Exception("Некорректный ввод числового значения для оси Z.");
                        }
                        Correct = true;
                        c1.Z = temp;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } while (!Correct);
            }
        }
        static void Main(string[] args)
        {
            Vector first = new Vector();    //создание нового объкета класса Vector
            Console.WriteLine("Введите координаты первого вектора относительно оси X.");    //сообщение пользователю
            Vector.SetX(first); //установка значения X в первом объекте посредством метода SetX
            Console.WriteLine("Введите координаты первого вектора относительно оси Y.");    //сообщение ползователю
            Vector.SetY(first); //установка значения Y в первом объекте посредством метода SetY
            Console.WriteLine("Введите координаты первого вектора относительно оси Z.");    //сообщение пользователю
            Vector.SetZ(first); //установка значения Z в первом объекте посредством метода SetZ
            Vector second = new Vector();    //создание нового объкета класса Vector
            Console.WriteLine("Введите координаты второго вектора относительно оси X.");    //сообщение пользователю
            Vector.SetX(second); //установка значения X во втором объекте посредством метода SetX
            Console.WriteLine("Введите координаты второго вектора относительно оси Y.");    //сообщение пользователю
            Vector.SetY(second); //установка значения Y во втором объекте посредством метода SetY
            Console.WriteLine("Введите координаты второго вектора относительно оси Z.");    //сообщение пользователю
            Vector.SetZ(second); //установка значения Z во втором объекте посредством метода SetZ
            Console.WriteLine("Если вы хотите сложить эти два вектора, введите 1.\nЕсли вы хотите вычесть один вектор из другого, введите 2.");  //эта и еще две строки - сообщения пользователю
            Console.WriteLine("Если вы хотите узнать длину одного из векторов, введите 3.\nЕсли вы хотите посчитать косинус между векторами, введите 4.");
            Console.WriteLine("Если вы хотите вычислить скалярное произведение векторов, введите 5.\nЕсли вы хотите покинуть программу, то введите любое другое число.");
            int a;  //объявление переменной, благодаря которой пользователь будет выбирать, что делать
            while (!int.TryParse(Console.ReadLine(), out a))    //пока пользователь не введет строку, которая может быть преобразована к типу int
            {
                Console.WriteLine("Некорректный ввод. Введите число."); //сообщение пользователю
            }
            switch (a)  //когда пользователь ввел число, программа пойдет по одному из 6 путей
            {
                case 1: //путь первый
                    {
                        Vector result = Vector.Sum(first, second);  //объявление объекта класса Vector, который будет содержать в себе результат работы метода Sum
                        Console.WriteLine($"Координаты вектора, полученного в результате сложения:\nx = {result.X}\ty = {result.Y}\tz = {result.Z}");   //вывод результатов на экран
                        break;  //завершение выполнения switch
                    }
                case 2: //путь второй
                    {
                        Console.WriteLine("Если вы хотите вычесть из первого вектора второй, введите 1.\nЕсли вы хотите вычесть из второго вектора первый, введите 2.");//соощение пользователю
                        while (!int.TryParse(Console.ReadLine(), out a) || (a != 1 && a != 2))  //пока пользователь не введет строку, которая может быть преобразована к типу int, и пока введенное не является 1 или 2
                        {
                            Console.WriteLine("Некорректный ввод. Введите 1 или 2.");   //сообщение пользователю
                        }
                        if (a == 1) //если введенное число = 1
                        {
                            Vector result = Vector.Subtruct(first, second); //объявление объекта класса Vector, который будет содержать в себе результат работы метода Subtruct
                            Console.WriteLine($"Координаты вектора, полученного в результате вычитания:\nx = {result.X}\ty = {result.Y}\tz = {result.Z}");//вывод результатов на экран
                        }
                        else   //в противном случае (то есть если введенное число = 2)
                        {
                            Vector result = Vector.Subtruct(second, first); //объявление объекта класса Vector, который будет содержать в себе результат работы метода Subtruct
                            Console.WriteLine($"Координаты вектора, полученного в результате вычитания:\nx = {result.X}\ty = {result.Y}\tz = {result.Z}");//вывод результатов на экран
                        }
                        //результат работы программы при вводе 1 или 2 будет разным из-за того, что в метод параметры передаются в разном порядке!
                        break;  //завершение выполнения switch
                    }
                case 3: //путь третий
                    {
                        Console.WriteLine("Если вы хотите узнать длину первого вектора, введите 1.\nЕсли вы хотите узнать длину второго вектора, введите 2.");//сообщение пользователю
                        while (!int.TryParse(Console.ReadLine(), out a) || (a != 1 && a != 2))  //пока пользователь не введет строку, которая может быть преобразована к типу int, и пока введенное не является 1 или 2
                        {
                            Console.WriteLine("Некорректный ввод. Введите 1 или 2.");   //сообщение пользователю
                        }
                        if (a == 1) //если введенное пользователем число = 1
                        {
                            Vector.Length(ref first);   //передача объекта класса по ссылке, чтобы метод НЕ КОПИРОВАЛ данные в локальную копию объекта, а работал с самим объектом
                            Console.WriteLine($"Длина первого вектора = {first.LEN}");  //вывод результатов на экран
                        }
                        else //в ином случае (то есть если в данной ситуации введенное число = 2)
                        {
                            Vector.Length(ref second);  //передача объекта по ссылке, чтобы метод работал с этим объектом непосредтсвенно, а не через локальную копию объекта
                            Console.WriteLine($"Длина первого вектора = {second.LEN}"); //вывод результатов на экран
                        }
                        //результат работы программы будет разным из-за того, что в функцию передаются разные объекты класса Vector
                        break;  //завершение выполнения switch
                    }
                case 4: //путь четвертый
                    {
                        double cos = Vector.Cos(first, second); //создание переменной, которая равняется результату работы метода Cos
                        Console.WriteLine($"Косинус угла между векторами = {cos}"); //вывод результатов на экран
                        break;  //завершение выполнения switch
                    }
                case 5: //путь пятый
                    {
                        double result = Vector.Multiply(first, second);
                        Console.WriteLine($"Скалярное произведение двух векторов = {result}");
                        break;  //завершение выполнения switch
                    }
                default://путь шестой сработает только в том случае, если пользователь ввел числа не из промежутка [1;5]
                    {
                        Console.WriteLine("Вы покидаете программу. До свидания!");  //сообщение пользователю
                        break;  //завершение выполнения switch
                    }
            }
            Console.ReadKey(); //требование нажатия на клавишу перед завершением программы позволяет задержать консоль
        }
    }
}