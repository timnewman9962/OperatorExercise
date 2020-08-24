using System;

namespace OperatorExercise
{
    class Program
    {
        
        static double AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\nPick a number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNow give me another number");
            int b = Convert.ToInt32(Console.ReadLine());

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("\nHere is some math we can do:\n" +
                            $"{a} + {b} is {a+b}\n" +
                            $"{a} - {b} is {a-b}\n" +
                            $"{a} * {b} is {a*b}\n" +
                            $"{a} / {b} is {quotient} remainder {remainder}\n" 
            );

            Console.WriteLine("-------\nNow lets find the area of a circle.\nGive me the radius");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine("The area is " + AreaOfCircle(radius));
            
        }
    }
}
