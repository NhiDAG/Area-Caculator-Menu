using System.Reflection.Metadata;

namespace Assignment1
{
    internal class Program
    {
        //calculate perimeter and area of a Triangle
        static (double perimeter, double area) calculateTriangle(double a, double b, double c){
            double perimeter = a + b + c;
            //p is semi-permeter
            double p = perimeter / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return (perimeter, area);
        }

        //calculator perimeter and area of a Square
        static (int perimeter, int area) calculateSquare(int side){
            int perimeter = side * 4;
            int area = side * side;
            return (perimeter, area);
        }

        //calculator perimeter and area of a Rectangle
        static (int perimeter, int area) calculateRectangle(int length, int width){
            int perimeter = (length + width) * 2;
            int area = length * width;
            return (perimeter, area);
        }

        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.WriteLine("---Choose shape to calculate perimeter and area---");
                Console.WriteLine("1.Triangle");
                Console.WriteLine("2.Square");
                Console.WriteLine("3.Rectangle");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Calculate Triangle:");
                        Console.Write("Enter a: ");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter b: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter c: ");
                        double c = Convert.ToDouble(Console.ReadLine());
                        var triangle = calculateTriangle(a, b, c);
                        Console.WriteLine($"Perimeter = {triangle.perimeter}, Area = {triangle.area}");
                        break;
                    case 2:
                        Console.WriteLine("Calculate Square:");
                        Console.Write("Enter length of side: ");
                        int side = Convert.ToInt32(Console.ReadLine());
                        var square = calculateSquare(side);
                        Console.WriteLine($"Perimeter = {square.perimeter}, Area = {square.area}");
                        break;
                    case 3:
                        Console.WriteLine("Calculate Rectangle:");
                        Console.Write("Enter length: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter width: ");
                        int width = Convert.ToInt32(Console.ReadLine());
                        var rectangle = calculateRectangle(length, width);
                        Console.WriteLine($"Perimeter = {rectangle.perimeter}, Area = {rectangle.area}");
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            } while (choice > 0);
            Console.ReadLine();
        }
    }
}
