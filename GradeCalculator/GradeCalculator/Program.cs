using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is you grade Calculator:");

            string name;
            float num1;
            float num2;
            float num3;
            float num4;
            float num5;
            float num6;

            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your  Mathimatics grade: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter your English grade: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter your  TLE grade: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter your  Science grade: ");
            num4 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter your  Filipino grade: ");
            num5 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter your Discrite PE grade: ");
            num6 = Convert.ToSingle(Console.ReadLine());

            // solutiion starts here
            float sum = num1 + num2 + num3 + num4 + num5 + num6;

            //Then devide it 
            float result = sum / 6;

            Console.WriteLine("Your General average is: " + result);

        }
    }
}
