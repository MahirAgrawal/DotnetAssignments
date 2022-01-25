using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Integer: \n");
          snippet0();
          snippet1();
          snippet2();
          snippet3();
          snippet4();
          snippet5();
          Console.WriteLine("\nDouble: \n");
          snippet6();
          snippet7();
          snippet8();
          Console.WriteLine("\nDecimal: \n");
          snippet9();
          snippet10();
          snippet11();
          snippet12();
        }
        static void snippet0(){
          int a = 1, b = 10,c = a+b;
          Console.WriteLine("Add: " + c);
          c = a-b;
          Console.WriteLine("Subtract: " + c);
          c = a*b;
          Console.WriteLine("Multiply: " + c);
          c = a/b;
          Console.WriteLine("Divide: " + c);
        }
        static void snippet1(){
        //showing BODMAS
          int a = 1, b = 10,c = 4,d = a+b*c;
          Console.WriteLine($"Snippet1: {d}");
        }
        static void snippet2(){
          int a = 1, b = 10,c = 4,d = (a+b)*c;
          Console.WriteLine($"Snippet2: {d}");
          d = (a + b) / c;
          Console.WriteLine($"Snippet2: {d}");
        }
        static void snippet3(){
          int a = 1, b = 10,c = 4,d = (a+b)/c,e = (a+b)%3;
          Console.WriteLine($"The Quotient is: {d}");
          Console.WriteLine($"The Remainder is: {e}");
        }
        static void snippet4(){
          Console.WriteLine($"The minValue for int is: {int.MinValue} & the maxValue for int is: {int.MaxValue}");
        }
        static void snippet5(){
          int max = int.MaxValue;
          int overflowbydumbmachine = max + 3;
          Console.WriteLine($"The Value for int is: {overflowbydumbmachine}");
        }
        static void snippet6(){
          double a = 1, b = 10,c = 4,d = (a+b)/c;
          Console.WriteLine($"Double ans: {d}");
        }
        static void snippet7(){
          Console.WriteLine($"The minValue for double is: {double.MinValue} & the maxValue for double is: {double.MaxValue}");
        }
        static void snippet8(){
          double third = 1.0 / 3.0;
          Console.WriteLine(third);
        }
        static void snippet9(){
          Console.WriteLine($"The minValue for Decimal is: {decimal.MinValue} & the maxValue for Decimal is: {decimal.MaxValue}");
        }
        static void snippet10(){
          Console.WriteLine("Double : " + 1.0 / 3.0);
          Console.WriteLine("Decimal : " + 1.0M / 3.0M);
        }
        static void snippet11(){
          //calculate the area of circle by using PI in math
          double radius = 2.5;
          Console.WriteLine($"The Area of Circle is {Math.PI*radius*radius} cm2\n");
        }
        static void snippet12(){
        }
    }
}