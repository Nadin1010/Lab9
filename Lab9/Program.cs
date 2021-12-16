using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            int cmd = 0;
            try
            {
                Console.WriteLine("Вас приветствует калькулятор!");
                Console.Write("Введите целое число x=");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите целое число Y=");
                y = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции: \n   1-сложение \n   2-вычитание \n   3-умножение \n   4-частное");
                Console.WriteLine("Ваш выбор:");
                cmd = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка ввода" + ex.Message);
                Console.ReadKey();
                return;
            } switch (cmd)
            {
                case 1:
                    {
                        Console.WriteLine("Результат равен = {0}", x + y);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Результат равен = {0}", x - y);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Результат равен = {0}", x * y);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            double result = x / y;
                            Console.WriteLine("Результат равен = {0:f2}", result);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Нет операции с указанным номером!");
                        break;
                    }
                    Console.ReadKey();
            }
        }
    }
}


