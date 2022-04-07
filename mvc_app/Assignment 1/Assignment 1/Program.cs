using System;
using System.Linq;

namespace Program{
    public class Customer{
        private string customerid="",city="";
        public Customer(string customerid,string city){
          this.customerid = customerid;
          this.city = city;
        }
        public string CustomerID{
            get{
              return this.customerid;  
            }
            set{
              this.customerid = value;
            }
        }

        public string City{
            get{
              return this.city;  
            }
            set{
              this.city = value;
            }
        }

        public override string ToString(){
            return this.customerid + "\t" + this.city;
        }
        public static void Main(){
            List<Customer> arr = new List<Customer>();
            arr.Add(new Customer("A123","London"));
            arr.Add(new Customer("B123","Paris"));
            arr.Add(new Customer("C123","Hyderbad"));
            arr.Add(new Customer("A001","New York"));
            arr.Add(new Customer("A005","Ullasnagar"));
            arr.Add(new Customer("C100","Vadodara"));
            arr.Add(new Customer("E1","London"));
            arr.Add(new Customer("C13","Mumbai"));
            arr.Add(new Customer("G12","London"));
            arr.Add(new Customer("D123","London"));

            //first query
            var row = from customer in arr
                      where customer.city == "London"
                      select customer;
            
            foreach(var cus in row){
              Console.WriteLine(cus);
            }
            
            //second query
            int count = (from customer in arr 
                        select customer).Count();
            
            Console.WriteLine("The Count of customer in List is: " + count);
            
            //third query
            row = from customer in arr
                  where customer.customerid.StartsWith('A')
                  select customer;
            
            foreach(var cus in row){
              Console.WriteLine(cus);
            }
        }
    }
}