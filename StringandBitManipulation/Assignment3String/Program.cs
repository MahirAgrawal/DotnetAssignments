//made by mahir
using System;

namespace Application{
  class Program{
    static void Main(string[] args){
      assignment3();
      assignment4();
    }
    static void assignment3(){
      Console.WriteLine("May I have the Numerator: ");
      int num = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("May I have the Denominator: ");
      int deno = Convert.ToInt32(Console.ReadLine());
      //Integer Arithmetic
      Console.WriteLine($"The Arithmetic Result of division of {num} with {deno} is: {num/deno} with remainder: {num%deno}");
      Console.WriteLine($"The Mixed Fraction is: {num/deno} * {num%deno} / {deno}");

      double dnum = num;
      double ddeno = deno;
      //Double Arithmetic
      Console.WriteLine($"The Floating Result of division of {num} with {deno} is: {dnum/ddeno}");
    }
    static void assignment4(){
      Console.WriteLine("May I have a string? ");
      string? str = Console.ReadLine();
      if(String.IsNullOrEmpty(str)){
        Console.WriteLine("Only Humans can expect the unexpected but not the machine. Give Input First");
        return;
      }
      Console.WriteLine("The Length of String is: " +  str.Length);
      char endchar = str[str.Length-1];
      if(endchar == '.')
        Console.WriteLine("You have got a Declarative Statment");
      else if(endchar == '?')
        Console.WriteLine("You have got a Interogative Statment");
      else if(endchar == '!')
        Console.WriteLine("You have got a Exclamatory Statment");
        else
        Console.WriteLine("You have bad style of writing grammer :(");
      
      //name program
      Console.WriteLine("What's your name?");
      string name = "" + Console.ReadLine();
      if(name.Length == 0){
        Console.WriteLine("Only Humans can expect the unexpected but not the machine. Give Input First");
        return;
      }
      //splits based on given deliminator given as argument in function parameter
      string[] nameArray = name.Split(' ');
      if(nameArray.Length > 2){
        Console.WriteLine("You had to just give name and surname!");
        return;
      }
      else if(nameArray.Length == 1){
        Console.WriteLine($"Welcome {name}\n");
      }
      else{
        Console.WriteLine($"Welcome in Hebrew Language {nameArray[1]} ,{nameArray[0]}\n");
      }
    }
  }
}