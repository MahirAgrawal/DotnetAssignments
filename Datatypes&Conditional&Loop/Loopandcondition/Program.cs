using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
	  Console.WriteLine("\nConditional Statements: \n");
          snippet0();
          snippet1();
          snippet2();
	  Console.WriteLine("\nLoop Statements: \n");
          snippet3();
          snippet4();
          snippet5();
          snippet6();
          snippet7();
        }
        static void snippet0(){
          int a = 5;
          int b = 1;
          if (a + b > 10)
            Console.WriteLine("The answer is greater than 10.");
        }
        static void snippet1(){
          int a = 5;
          int b = 1;
          if (a + b > 10)
            Console.WriteLine("The answer is greater than 10.");
          else
            Console.WriteLine("The answer is smaller than or equal to 10");          
        }
        static void snippet2(){
          int a = 5,b = 10 ,c = 10;
          if((a+b+c > 10) || (b == c)){
            Console.WriteLine("The summation is larger than 10 or b equals c");
          }
          else{
            Console.WriteLine("The summation is smaller than 10 and b not equals c");
          }
        }
        static void snippet3(){
          int counter = 0;
          while(counter < 10){
            Console.WriteLine($"While loop I am! The Counter is {counter}");
            counter++;
          }
        }
        static void snippet4(){
          //run and then checks the condition
          int counter = 0;
          do{
            Console.WriteLine($"Do while I am! The Counter is {counter}");
            counter++;
          }while(counter < 10);         
        }
        static void snippet5(){
          for(int counter = 0; counter < 10; counter++)
          {
            Console.WriteLine($"For loop I am! The Counter value is {counter}");
          }
        }
        static void snippet6(){
          //nested loops 
          int row = 5,col = 2;
          for(int i = 0; i < row; i++){
            for(int j = 0; j < col; j++){
              Console.WriteLine("The row and col: " + i + " " + j);
            }
          }
        }
        static void snippet7(){
          //  find the sum of all integers 1 through 20 that are divisible by 3
          int sum = 0;
          for(int i = 1; i <= 20; i++){
            if(i%3 == 0){
              sum += i;
            }
          }
          Console.WriteLine("The Sum is : " + sum);
        }
    }
}