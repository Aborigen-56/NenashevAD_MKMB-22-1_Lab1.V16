using Tyuiu.NenashevAD.Lab1.Review.V16.Lib;
namespace Tyuiu.NenashevAD.Lab2.TaskReview.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 z1 = new Class1();
            Class2 z2 = new Class2();
            Console.Title = "Спринт #1 | Выполнил: Ненашев А.Д. | МКМб-22-1";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Лабраторная работа #1                                                      *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #16                                                                *");
            Console.WriteLine("* Выполнил: Ненашев Артем Денисович | МКМб-22-1                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("X: = - 2");
            Console.WriteLine("Y: = 2");
            Console.WriteLine("A: = 3");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("-----------------------");
            int x = -2; int y = 2; int a = 3;
            Console.WriteLine("* Первая функция:                                                            *");
            double zf1 = z1.Zfunc1(x, y, a);
            Console.WriteLine($"z = {zf1}");
            Console.WriteLine("* Вторая функция:                                                            *");
            double zf2 = z2.Zfunc2(x, y, a);
            Console.WriteLine($"z = {zf2}");
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }
    }
}