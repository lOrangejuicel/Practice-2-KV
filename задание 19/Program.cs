/*
Дано уравнение ax2-bx+c=e. Найти х. Math.Pow(x, y), где x – число возводимое в степень, y – показатель степени.
*/

namespace задание_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение e: ");
            double e = Convert.ToDouble(Console.ReadLine());

            double D = Math.Pow(b, e) - 4 * a * c;
            if (D > 0) 
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"Уравнение имеет два корня: x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0) 
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {x}");
            }
            else 
            {
                Console.WriteLine("Уравнение не имеет действительных корней.");
            }
        }
    }
}
