namespace Tyuiu.NenashevAD.Lab1.Review.V16.Lib
{
    public class Class1
    {
        public double Zfunc1(double x, double y, double a)
        {
            return Math.Round(((3 * a / y) / (4 * a * (a * a / y)) / y) - x + (a * a / y + 5 * y - 3 * a) / (x + 9 * y), 2); ;
        }
    }

    public class Class2
    {
        public double Zfunc2(double x, double y, double a)
        {
            return (2 + 3 * a) / (4 * x + 3 * y) + (3 + (3 * x + a)/(x - 2)) * x * a;
        }
    }
}