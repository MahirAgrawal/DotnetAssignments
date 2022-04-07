using System;

namespace Application{
  class Balance{
    public int balance;
    public Balance(int a){
      this.balance = a;
    }
  }
  class Program{
    public static void CallAnonymousMethod(){
      bool positive = new Func<int, bool>(delegate (int int32) { return int32> 0; })(1);
      new Action<bool>(delegate (bool value) { Console.WriteLine(value); })(positive);
    }
    public static void CallLambda(){
      bool positive = new Func<int, bool>(int32 => int32 > 0)(1);
      new Action<bool>(value =>Console.WriteLine(value))(positive);
    }
    public static void Main(string[] args){
      CallAnonymousMethod();
      CallLambda();
      var parse = (double x, double y) => (x > y ? x : y);
      Func<double, double, double> f =  (x, y) => {
        if (x > y)return x;
        else return y;
      };
      Console.WriteLine(parse(10.32,102.1));
      Console.WriteLine(f(102.32,102.1));
    }
    static void Main1(string[] args){
      Action<Balance> print = getmssg;
      print(new Balance (1003)); 
      print(new Balance(1)); 
      print(new Balance(-100)); 
      print(new Balance (13)); 
    }

    public static void getmssg(Balance b){
      if(b.balance < 0){
        Console.WriteLine("You are overdrawn");
      }
      else if(b.balance < 10){
        Console.WriteLine("Your balance is very low");
      }
      else if(b.balance < 100){
        Console.WriteLine("Watch your spending carefully");
      }
      else{
        Console.WriteLine("You have over $100 in your account");
      }
    } 
  }

}