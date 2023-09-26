using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_WorkSheet_Essential_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Essential task 4

            Console.WriteLine("Enter the length of side a:");

            float lengthofA = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side b:");

            float lengthofB = Int32.Parse(Console.ReadLine());

            double hyp = Math.Sqrt((Math.Pow(lengthofA, 2) + Math.Pow(lengthofB, 2))); // calc hyp

            Console.Write($"\nLenght of C is {hyp:F2}M"); // write hyp M
            Console.Write($" ({hyp*100:F2}CM)"); // write hyp CM

            double area = ((lengthofA * lengthofB) / 2); // calc area

            Console.Write($"\nArea of triangle is {area:F2}M"); // write area
            Console.Write($" ({area*100:F2}CM)"); // write area

            Console.ReadKey();

            //Essential task 5
            // Temperature conversion formula
            // Kelvin = Celsius + 273
            // Fahrenheit = 32 + ((Celsius * 9)/5)

            Console.WriteLine("\n\nHello please, Type temperature in celsius"); // Ask for input

            double.TryParse(Console.ReadLine(), out double celsiusInput);  //Convert input into a double

            Console.WriteLine($"\nKelvin: {celsiusInput + 273}K");
            Console.WriteLine($"\nFahrenheit: {(((celsiusInput*9)/5)+32):F0}F");

            Console.ReadKey();

        }
    }
}
