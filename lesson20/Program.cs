using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson20
{
    /*В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
-       метод получает входным параметром переменную типа double;
-       метод возвращает значение типа double, которое является результатом вычисления.

Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
-       длину окружности по формуле D = 2 * π * R;
-       площадь круга по формуле S = π* R²;
-       объем шара.Формула V = 4 / 3 * π * R³.

Методы должны быть объявлены как статические.*/
    class Program
    {
        delegate double MyDelegate(double radius);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = Geometry.LengthCircle;
            double length = myDelegate(radius);
            Console.WriteLine("Длина окружности: {0}",length);

            MyDelegate myDelegate2 = Geometry.SquareCircle;
            double square = myDelegate2(radius);
            Console.WriteLine("Площадь круга: {0}", square);

            MyDelegate myDelegate3 = Geometry.VolumeBall;
            double volume = myDelegate3(radius);
            Console.WriteLine("Объем шара: {0}", volume);

            Console.ReadKey();
        }
    }
    static public class Geometry
    {
        static public double LengthCircle(double radius)
        {
            return 2 * Math.PI * radius;
        }
        static public double SquareCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
        static public double VolumeBall(double radius)
        {
            return 4 * Math.PI * Math.Pow(radius, 3) / 3;
        }
    }
}
