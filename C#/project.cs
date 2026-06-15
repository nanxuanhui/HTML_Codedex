using System;

class Program
{
    static void Main()
    {
        string again = "y";

        while (again.ToLower() == "y")
        {
            Console.WriteLine("==================");
            Console.WriteLine("Area Calculator 📐");
            Console.WriteLine("==================");
            Console.WriteLine("1) Triangle");
            Console.WriteLine("2) Rectangle");
            Console.WriteLine("3) Square");
            Console.WriteLine("4) Circle");
            Console.WriteLine("5) Quit");
            Console.WriteLine();

            Console.Write("Which shape: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            double area = 0;

            if (choice == 1)
            {
                Console.Write("Base: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Height: ");
                double h = Convert.ToDouble(Console.ReadLine());

                area = (b * h) / 2;
            }
            else if (choice == 2)
            {
                Console.Write("Length: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                area = length * width;
            }
            else if (choice == 3)
            {
                Console.Write("Side: ");
                double side = Convert.ToDouble(Console.ReadLine());

                area = side * side;
            }
            else if (choice == 4)
            {
                Console.Write("Radius: ");
                double radius = Convert.ToDouble(Console.ReadLine());

                area = 3.14 * radius * radius;
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            Console.WriteLine();
            Console.WriteLine("The area is " + area);
            Console.WriteLine();

            Console.Write("Calculate again? (y/n): ");
            again = Console.ReadLine();
            Console.WriteLine();
        }
    }
}