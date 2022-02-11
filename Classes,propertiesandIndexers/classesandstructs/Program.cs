class TimePeriod{
   private double _seconds;

   public double Hours{
       get { 
         return _seconds / 3600;
        }
       set {
          if (value < 0 || value > 24)
             throw new ArgumentOutOfRangeException(
                   $"{nameof(value)} must be between 0 and 24.");

          _seconds = value * 3600;
       }
   }
}
class Person{
   private string _firstName;
   private string _lastName;

   public Person(string first, string last){
      _firstName = first;
      _lastName = last;
   }

   public string Name => $"{_firstName} {_lastName}";
}
public class SaleItem{
   string _name;
   decimal _cost;

   public SaleItem(string name, decimal cost){
      _name = name;
      _cost = cost;
   }

   public string Name{
      get => _name;
      set => _name = value;
   }

   public decimal Price{
      get => _cost;
      set => _cost = value;
   }
}

public class AutoSaleItem{
   public string? Name
   { get; set; }

   public decimal Price
   { get; set; }
}

class Test{
   static void Main(){
     Console.WriteLine("By: Mihir L. Agrawal\n");
      TimePeriod t = new TimePeriod();
      t.Hours = 12;
      Console.WriteLine($"Time in hours: {t.Hours}\n");
      Person p = new Person("Mihir","Agrawal");
      Console.WriteLine($"The Name of Person: {p.Name}\n");
      SaleItem s = new SaleItem("Book",99.0m);
      Console.WriteLine($"The {s.Name} costs : {s.Price}\n");
      //Auto implemented
      AutoSaleItem asi = new AutoSaleItem{Name = "Car",Price = 999.234m};
      Console.WriteLine($"The {asi.Name} costs : {asi.Price}\n");
   }
}