using System;

namespace Application{
  class Sort{

    public static void swap<X>(List<X> arr,int a,int b){
      X temp = arr[a];
      arr[a] = arr[b];
      arr[b] = temp;
    }

    //actual quicksort which sorts the list based on function delegates
    public static void quicksort<X>(int s,int e,List<X> arr,Func<X,X,bool> comparator){
      if(s>=e)return;
      int random_pivot = (s+e)/2;
      swap<X>(arr,e,random_pivot);
      int to_swap_with = s;
      for(int i = s;i < e;i++){
        //if false then arrangement is not of proper order so we swap it
        if(comparator(arr[i],arr[e])){
          swap(arr,to_swap_with,i);
          to_swap_with++;
        }
      }
      swap(arr,to_swap_with,e);
      quicksort<X>(s,to_swap_with-1,arr,comparator);
      quicksort<X>(to_swap_with+1,e,arr,comparator);
    }

    //quicksort caller which passes the required argument pointers to run quicksort
    public static void sort<X>(List<X> arr,Func<X,X,bool> comparator){
      quicksort(0,arr.Count-1,arr,comparator);
    }
  }

  class Employee{
    public string name="";
    public Employee(string name){
      this.name = name;
    }
  }

  class coord{
    public int x,y;
    public coord(int x,int y){
      this.x = x;
      this.y = y;
    }
  }
  class Program{

    //method overloading
    
    //comparator for employee
    static bool comparator(Employee a,Employee b){
      return String.Compare(a.name,b.name)<0;
    }

    //comparator for int in descending order
    static bool comparator(int a,int b){
      return a>b;
    }

    //comparator for coordinates
    static bool comparator(coord a,coord b){
      if(a.x == b.x)
        return a.y<b.y;
      else
        return a.x<b.x;
    }
    static void Main(string[] args){
      List<Employee> emp = new List<Employee>();
      emp.Add(new Employee("OWEJFKM"));
      emp.Add(new Employee("FDJFK"));
      emp.Add(new Employee("SFJDKDFF"));
      emp.Add(new Employee("FGC"));
      emp.Add(new Employee("GDG"));
      Console.WriteLine("Before Comparison: ");
      foreach(var e in emp){
        Console.Write(e.name + " ");
      }
      Console.WriteLine('\n');
      Sort.sort(emp,comparator);
      Console.WriteLine("After Comparison: ");
      foreach(var e in emp){
        Console.Write(e.name + " ");
      }
      Console.WriteLine('\n');
      List<int> arr = new List<int>(6);
      arr.Add(4);
      arr.Add(6);
      arr.Add(7);
      arr.Add(8);
      arr.Add(3);
      arr.Add(1);
      Console.WriteLine("Before Comparison: ");
      foreach(var num in arr){
        Console.Write(num + " ");
      }
      Console.WriteLine('\n');
      Sort.sort(arr,comparator);
      Console.WriteLine("After Comparison: ");
      foreach(var num in arr){
        Console.Write(num + " ");
      }
      Console.WriteLine('\n');
      List<coord> coordarr = new List<coord>();
      coordarr.Add(new coord(3,0));
      coordarr.Add(new coord(3,3));
      coordarr.Add(new coord(2,1));
      coordarr.Add(new coord(-1,43));
      coordarr.Add(new coord(0,1));
      coordarr.Add(new coord(0,0));
      coordarr.Add(new coord(10,10));
      Console.WriteLine("Before Comparison: ");
      foreach(var point in coordarr){
        Console.Write("{" + point.x + " " + point.y + "} ");
      }
      Console.WriteLine('\n');
      Sort.sort(coordarr,comparator);
      Console.WriteLine("After Comparison: ");
      foreach(var point in coordarr){
        Console.Write("{" + point.x + " " + point.y + "} ");
      }
      Console.WriteLine('\n');
    }
  }

}