using System;
namespace Indexers{

  class Collection<T>{
    private T[] arr = new T[100];
    public T this[int i]{
      get{return arr[i];}
      set{arr[i]=value;}
    }
  }

  class vector<T>{
    private T[] arr = new T[5];
    public int curr = 0,size_ = 5;
    public T this[int i]{
      get{
      if(i>=size_ || i < 0) 
        throw new IndexOutOfRangeException("Out of bounds Accessing is not possible\n");
        return arr[i];
      }
      set{
        if(i>=size_ || i < 0) 
          throw new IndexOutOfRangeException("Out of bounds Accessing is not possible\n");
        arr[i] = value;
      }
    }
    public void push_back(T value){
      if(curr==size_)
          throw new IndexOutOfRangeException($"Max Size of array is {size_}\n");
      arr[curr++] = value;
    }
  } 
  class test{
    public static void Main(){
      Collection<double> salary = new Collection<double>();
      salary[0] = 1.04;
      salary[1] = 20.10;
      salary[2] = 40.23;
      for(int i = 0;i < 3;i++)
        Console.Write(salary[i]+" ");
      Console.Write("\n\n");

      vector<string> arr = new vector<string>();
      string[] lyrics = {"First things","First","I'm gonna" ,"say all the words","inside my head"};
      foreach(string s in lyrics){
        arr.push_back(s);
      }
      for(int i = 0; i < arr.curr;i++){
        Console.Write(arr[i] + " ");
      }
    } 
  }

}