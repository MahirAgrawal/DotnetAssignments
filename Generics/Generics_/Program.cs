//Created by mihiragrawal022
// Create classes with fields as given below:
// Indica – type, seater, renttype,rentperunit, age, number,lastmaintenancedate,
// Qualis – type, seater, renttype,rentperunit, age, number,lastmaintenancedate,
// Davidharley – renttype,rentperunit,age,number,lastmaintenancedate,
// MBenzEclass – seater,renttype,rentperunit,age,number,lastmaintenancedate,
// Create a class RentedVehicle<T> where T we will use classes like Indica, Qualis, David Harley, Mercedes Benz E class
// RentedVehicle<T> has fields startdateofrent,enddateofrent,noofkmstravelled,advancepayment
// Given below are some methods that RentedVehicle<T> will implement
// · GiveForRent – noofkms,startdate,enddate,advancepayment
// · CalculateRent – noofkms,noofdays,
// · CalculateTotalRentToday
// · GetCheckListREntedandAvailableVehicle
// · GetCheckListvehilcesinmaintainence
// · ShowAvailabilityforbookingforgivendate
// Sample Code for driver class main method:
// REntedVehicle<Indica> indica1=newRentedVehicle<Indica>();
// RentedVehicle<Qualis>[] ArrQualis = new RentedVehilce<Qualis>[4];

using System;

namespace Application{

  interface ICars{
    public double getRent(DateTime s,DateTime e);
    public string getrenttype();
    public double getrentperunit();
  }
  class Indica : ICars{
    private bool isPetrol=false;
    private int seater,age;
    private DateTime lastmaintainancedate; 
    private string license="";
    private double renttype = 0;
    private string rentperwhat = "";
    private double rentperunit;
    public Indica(){
      isPetrol = false;
      Console.Write("Does it run on Petrol(Y/N): ");
      string tem = ""+Console.ReadLine();
      if(tem == "Y" || tem == "y")
        isPetrol = true;

      Console.Write("Enter the age of Car: ");
      this.age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the number of Seats in Car: ");
      this.seater = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the Year(YYYY) of last maintainance:");
      int y = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Month(MM) of last maintainance:");
      int m = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Date(DD) of last maintainance:");
      int d = Convert.ToInt32(""+Console.ReadLine());
      this.lastmaintainancedate = new DateTime(y,m,d);

      Console.Write("Enter the license of Car: ");
      this.license=""+Console.ReadLine();

      Console.Write("Enter Rent per which unit?(w,h,d)(w:week d:day h:hour) ");
      string temp = ""+Console.ReadLine();
      if(temp == "w" || temp == "W"){
        renttype = 1/7.0;
        rentperwhat = "week";
      }
      else if(temp == "h" || temp == "H"){
        renttype = 24.0;
        rentperwhat = "hour";
      }
      else{
        renttype = 1.0;
        rentperwhat = "day";
      }

      Console.Write($"Enter the rent per {rentperwhat} of Car: ");
      this.rentperunit = Convert.ToDouble(Console.ReadLine());
    }

    public double getRent(DateTime start,DateTime end){
      return rentperunit*renttype*(double)(1+Convert.ToInt32((end-start).Days));
    }

    public string getrenttype(){
      return rentperwhat;
    }
    public double getrentperunit(){
      return rentperunit;
    }
    
  }

  class Qualis : ICars{
    private bool isPetrol=false;
    private int seater,age;
    private DateTime lastmaintainancedate; 
    private string license="";
    private double renttype = 0;
    private string rentperwhat="";
    private double rentperunit;
    public Qualis(){
      isPetrol = false;
      Console.Write("Does it run on Petrol(Y/N): ");
      string tem = ""+Console.ReadLine();
      if(tem == "Y" || tem == "y")
        isPetrol = true;

      Console.Write("Enter the age of Car: ");
      this.age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the number of Seats in Car: ");
      this.seater = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the Year(YYYY) of last maintainance:");
      int y = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Month(MM) of last maintainance:");
      int m = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Date(DD) of last maintainance:");
      int d = Convert.ToInt32(""+Console.ReadLine());
      this.lastmaintainancedate = new DateTime(y,m,d);

      Console.Write("Enter the license of Car: ");
      this.license=""+Console.ReadLine();

      Console.Write("Enter Rent per which unit?(w,h,d)(w:week d:day h:hour) ");
      string temp = ""+Console.ReadLine();
      if(temp == "w" || temp == "W"){
        renttype = 1/7.0;
        rentperwhat = "week";
      }
      else if(temp == "h" || temp == "H"){
        renttype = 24.0;
        rentperwhat = "hour";
      }
      else{
        renttype = 1.0;
        rentperwhat = "day";
      }

      Console.Write($"Enter the rent per {rentperwhat} of Car: ");
      this.rentperunit = Convert.ToDouble(Console.ReadLine());
    }

    public double getRent(DateTime start,DateTime end){
      return rentperunit*renttype*(double)(1+Convert.ToInt32((end-start).Days));
    }
    public string getrenttype(){
      return rentperwhat;
    }
    public double getrentperunit(){
      return rentperunit;
    }
  }

  class MBenzEclass: ICars{
    private int seater,age;
    private DateTime lastmaintainancedate; 
    private string license="";
    private double renttype = 0;
    private string rentperwhat = "";
    private double rentperunit;
    public MBenzEclass(){

      Console.Write("Enter the age of Car: ");
      this.age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the number of Seats in Car: ");
      this.seater = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the Year(YYYY) of last maintainance:");
      int y = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Month(MM) of last maintainance:");
      int m = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Date(DD) of last maintainance:");
      int d = Convert.ToInt32(""+Console.ReadLine());
      this.lastmaintainancedate = new DateTime(y,m,d);

      Console.Write("Enter the license of Car: ");
      this.license=""+Console.ReadLine();

      Console.Write("Enter Rent per which unit?(w,h,d)(w:week d:day h:hour) ");
      string temp = ""+Console.ReadLine();
      if(temp == "w" || temp == "W"){
        renttype = 1/7.0;
        rentperwhat = "week";
      }
      else if(temp == "h" || temp == "H"){
        renttype = 24.0;
        rentperwhat = "hour";
      }
      else{
        renttype = 1.0;
        rentperwhat = "day";
      }

      Console.Write($"Enter the rent per {rentperwhat} of Car: ");
      this.rentperunit = Convert.ToDouble(Console.ReadLine());
    }

    public double getRent(DateTime start,DateTime end){
      return rentperunit*renttype*(double)(1+Convert.ToInt32((end-start).Days));
    }

    public string getrenttype(){
      return rentperwhat;
    }
    public double getrentperunit(){
      return rentperunit;
    }

  }

  class Davidharley: ICars{
    private int age;
    private DateTime lastmaintainancedate; 
    private string license="";
    private double renttype = 0;
    private string rentperwhat = "";
    private double rentperunit;
    public Davidharley(){

      Console.Write("Enter the age of Car: ");
      this.age = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the Year(YYYY) of last maintainance:");
      int y = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Month(MM) of last maintainance:");
      int m = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Date(DD) of last maintainance:");
      int d = Convert.ToInt32(""+Console.ReadLine());
      this.lastmaintainancedate = new DateTime(y,m,d);

      Console.Write("Enter the license of Car: ");
      this.license=""+Console.ReadLine();

      Console.Write("Enter Rent per which unit?(w,h,d)(w:week d:day h:hour) ");
      string temp = ""+Console.ReadLine();
      if(temp == "w" || temp == "W"){
        renttype = 1/7.0;
        rentperwhat = "week";
      }
      else if(temp == "h" || temp == "H"){
        renttype = 24.0;
        rentperwhat = "hour";
      }
      else{
        renttype = 1.0;
        rentperwhat = "day";
      }

      Console.Write($"Enter the rent per {rentperwhat} of Car: ");
      this.rentperunit = Convert.ToDouble(Console.ReadLine());
    }

    public double getRent(DateTime start,DateTime end){
      return rentperunit*renttype*(double)(1+Convert.ToInt32((end-start).Days));
    }
    public string getrenttype(){
      return rentperwhat;
    }
    public double getrentperunit(){
      return rentperunit;
    }

  }

  //T expects classname which implements ICars
  class RentedVehicle<T> where T: ICars,new(){
    DateTime startdateofrent;//stores the start of ongoing rent
    bool OnRent = false;//flag to check if car is onrent or not
    bool InMaintainance = false;//flag to check if car is on maintainance or not
    double advancepayment=0;//advancepayment if given for ongoing rent
    double numberofkmstravelled=0;//stores total number of kms travelled for all rents till date
    T car;
    public RentedVehicle(){
      car = new T();
      this.numberofkmstravelled = 0;
    } 
    
    //gives car for maintainance
    public void giveformaintainance(){
      InMaintainance = true;
      Console.WriteLine("Car is given for maintainance!!");
    }

    //brings back from maintainance
    public void getfrommaintainance(){
      InMaintainance = false;
      Console.WriteLine("Car is retrieved from maintainance!!");
    }
    //give car of this class to rent
    //initialize start date to today
    public bool checkRented(){
      return OnRent;
    }

    public bool checkInmaintainance(){
      return InMaintainance;
    }
    public bool giveforRent(){
      startdateofrent = DateTime.Now;
      OnRent = true;
      Console.Write("Enter the Advance Payment(0 if not) of Car: ");
      this.advancepayment = Convert.ToDouble(Console.ReadLine());
      return true;
    }

    //making car again available for rent and calculates the cost of current renting period
    public void CalculateTotalRentToday(){
      //checks if car is not on rent at all
      if(!OnRent){
        Console.WriteLine("Car is not on Rent");
        return;
      }

      //summarizing costs and making car available
      Console.Write("Enter the Year(YYYY) of Return of Car:");
      int y = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Month(MM) of Return of Car:");
      int m = Convert.ToInt32(""+Console.ReadLine());
      Console.Write("Enter the Date(DD) of Return of Car:");
      int d = Convert.ToInt32(""+Console.ReadLine());
      //deduct advance payment from the overall cost
      Console.WriteLine($"Collect : {this.car.getRent(this.startdateofrent,new DateTime(y,m,d))-this.advancepayment}");
      Console.Write("Enter the number of Kilometers travelled for this rent: ");
      this.numberofkmstravelled += Convert.ToInt32(Console.ReadLine());
      this.advancepayment = 0;
      OnRent = false;
    }

    public override string ToString(){
      string info = "";
      info += "Number of kms Travelled: " + this.numberofkmstravelled + "\n";
      info += "Unit for rent: " + this.car.getrenttype() + "\n";
      info += "Price per unit: " + this.car.getrentperunit() + "\n";
      return info;
    } 
  }

  
  //reason for not including the last three methods in rentedvehicle:
  //1)The methods will include data for all cars but rentedvehicle stores info of one car
  //  hence static members has to be used like array or list which stores all cars made with rentedvehicle
  //2)Static members includes not only one method but three methods and also includes static arrays
  //  to keep tracks of rentedcars, and not rented cars thus total cars. So to keep the rentedvehicle class clean
  // and flow of calls clear i have included all static members in apiclassforcar which user will interact directly.
  class APIforcar{
    
    //static members
    static List<RentedVehicle<Indica>> IndicaCars = new List<RentedVehicle<Indica>>();
    static List<RentedVehicle<Qualis>> QualisCars = new List<RentedVehicle<Qualis>>();
    static List<RentedVehicle<MBenzEclass>> MBenzEclassCars = new List<RentedVehicle<MBenzEclass>>();
    static List<RentedVehicle<Davidharley>> DavidharleyCars = new List<RentedVehicle<Davidharley>>();

    public static int menu(){
      int option=0;
      do{
      Console.WriteLine("1. Add new Car");
      Console.WriteLine("2. Give Car For Rent");
      Console.WriteLine("3. Return Car and Calculate Rent");
      Console.WriteLine("4. Give Car for maintainance");
      Console.WriteLine("5. Get Car from maintainance");
      Console.WriteLine("6. Show Avaiable and Rented Car(s)");
      Console.WriteLine("7. Show Car(s) in Maintainance");
      Console.WriteLine("8. Exit");
      Console.Write("Enter the number of operation to perform it:");
      option = Convert.ToInt16(Console.ReadLine());
      }while(option<1 || option>8);
      return option;
    }

    public static void addCar(){
      int option=0;
      do{
      Console.WriteLine("Enter number for the new Car company: ");
      Console.WriteLine("1.Indica\n2.Qualis\n3.MBenzE\n4.Davidharley");
      option = Convert.ToInt16(Console.ReadLine());
      }while(option<1 || option>4);
      switch(option){
        case 1:
          Console.WriteLine("You have choosen Indica");
          IndicaCars.Add(new RentedVehicle<Indica>());
          break;
        case 2:
          Console.WriteLine("You have choosen Qualis");
          QualisCars.Add(new RentedVehicle<Qualis>());
          break;
        case 3:
          Console.WriteLine("You have choosen MBenzE");
          MBenzEclassCars.Add(new RentedVehicle<MBenzEclass>());
          break;
        case 4:
          Console.WriteLine("You have choosen Davidharley");
          DavidharleyCars.Add(new RentedVehicle<Davidharley>());
          break;
      }
      Console.WriteLine("Car Added To Portfolio!");      
    }
    public static void giveForrent(){
      int option=0;
      do{
      Console.WriteLine("Enter number for the Car company: ");
      Console.WriteLine("1.Indica\n2.Qualis\n3.MBenzE\n4.Davidharley");
      option = Convert.ToInt16(Console.ReadLine());
      }while(option<1 || option>4);
      switch(option){
        case 1:
          Console.WriteLine("You have choosen Indica\n");
          bool flag = false;
          foreach(var car in IndicaCars){
            flag |= (!car.checkRented());
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is available for renting.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < IndicaCars.Count;i++){
            var car = IndicaCars[i];
            if(car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < IndicaCars.Count && (!IndicaCars[option].checkRented())){
            IndicaCars[option].giveforRent();
          }
          else{
            Console.WriteLine("Car Id not available for Rent");
          }
          break;
        case 2:
          Console.WriteLine("You have choosen Qualis");
          flag = false;
          foreach(var car in QualisCars){
            flag |= (!car.checkRented());
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is available for renting.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < QualisCars.Count;i++){
            var car = QualisCars[i];
            if(car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < QualisCars.Count && (!QualisCars[option].checkRented())){
            QualisCars[option].giveforRent();
          }
          else{
            Console.WriteLine("Car Id not available for Rent");
          }
          break;
        case 3:
          Console.WriteLine("You have choosen MBenzE");
          flag = false;
          foreach(var car in MBenzEclassCars){
            flag |= (!car.checkRented());
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is available for renting.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < MBenzEclassCars.Count;i++){
            var car = MBenzEclassCars[i];
            if(car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < MBenzEclassCars.Count && (!MBenzEclassCars[option].checkRented())){
            MBenzEclassCars[option].giveforRent();
          }
          else{
            Console.WriteLine("Car Id not available for Rent");
          }
          break;
        case 4:
          Console.WriteLine("You have choosen Davidharley");
          flag = false;
          foreach(var car in DavidharleyCars){
            flag |= (!car.checkRented());
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is available for renting.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < DavidharleyCars.Count;i++){
            var car = DavidharleyCars[i];
            if(car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < DavidharleyCars.Count && (!DavidharleyCars[option].checkRented())){
            DavidharleyCars[option].giveforRent();
          }
          else{
            Console.WriteLine("Car Id not available for Rent");
          }
          break;
      }
    }
    public static void returnCar(){
      int option=0;
      do{
      Console.WriteLine("Enter number for the Car company: ");
      Console.WriteLine("1.Indica\n2.Qualis\n3.MBenzE\n4.Davidharley");
      option = Convert.ToInt16(Console.ReadLine());
      }while(option<1 || option>4);
      switch(option){
        case 1:
          Console.WriteLine("You have choosen Indica\n");
          bool flag = false;
          foreach(var car in IndicaCars){
            flag |= car.checkRented();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is out on rent.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < IndicaCars.Count;i++){
            var car = IndicaCars[i];
            if(!car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < IndicaCars.Count){
            IndicaCars[option].CalculateTotalRentToday();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 2:
          Console.WriteLine("You have choosen Qualis");
          flag = false;
          foreach(var car in QualisCars){
            flag |= car.checkRented();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is out on rent.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < QualisCars.Count;i++){
            var car = QualisCars[i];
            if(!car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < QualisCars.Count){
            QualisCars[option].CalculateTotalRentToday();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 3:
          Console.WriteLine("You have choosen MBenzE");
          flag = false;
          foreach(var car in MBenzEclassCars){
            flag |= car.checkRented();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is out on rent.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < MBenzEclassCars.Count;i++){
            var car = MBenzEclassCars[i];
            if(!car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < MBenzEclassCars.Count){
            MBenzEclassCars[option].CalculateTotalRentToday();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 4:
          Console.WriteLine("You have choosen Davidharley");
          flag = false;
          foreach(var car in DavidharleyCars){
            flag |= car.checkRented();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is out on rent.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < DavidharleyCars.Count;i++){
            var car = DavidharleyCars[i];
            if(!car.checkRented())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < DavidharleyCars.Count){
            DavidharleyCars[option].CalculateTotalRentToday();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
      }
    }
    public static void giveformaintainance(){
      int option=0;
      do{
      Console.WriteLine("Enter number for the Car company: ");
      Console.WriteLine("1.Indica\n2.Qualis\n3.MBenzE\n4.Davidharley");
      option = Convert.ToInt16(Console.ReadLine());
      }while(option<1 || option>4);
      switch(option){
        case 1:
          Console.WriteLine("You have choosen Indica\n");
          bool flag = false;
          foreach(var car in IndicaCars){
            flag |= (!car.checkInmaintainance());
          }
          if(!flag){
            Console.WriteLine("All of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < IndicaCars.Count;i++){
            var car = IndicaCars[i];
            if(car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < IndicaCars.Count && !IndicaCars[option].checkInmaintainance()){
            IndicaCars[option].giveformaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 2:
          Console.WriteLine("You have choosen Qualis");
          flag = false;
          foreach(var car in QualisCars){
            flag |= (!car.checkInmaintainance());
          }
          if(!flag){
            Console.WriteLine("All of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < QualisCars.Count;i++){
            var car = QualisCars[i];
            if(car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < QualisCars.Count && !QualisCars[option].checkInmaintainance()){
            QualisCars[option].giveformaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 3:
          Console.WriteLine("You have choosen MBenzE");
          flag = false;
          foreach(var car in MBenzEclassCars){
            flag |= (!car.checkInmaintainance());
          }
          if(!flag){
            Console.WriteLine("All of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < MBenzEclassCars.Count;i++){
            var car = MBenzEclassCars[i];
            if(car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < MBenzEclassCars.Count && !MBenzEclassCars[option].checkInmaintainance()){
            MBenzEclassCars[option].giveformaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 4:
          Console.WriteLine("You have choosen Davidharley");
          flag = false;
          foreach(var car in DavidharleyCars){
            flag |= (!car.checkInmaintainance());
          }
          if(!flag){
            Console.WriteLine("All of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < DavidharleyCars.Count;i++){
            var car = DavidharleyCars[i];
            if(car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < DavidharleyCars.Count && !DavidharleyCars[option].checkInmaintainance()){
            DavidharleyCars[option].giveformaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
      }
    }
    public static void getfrommaintainance(){
      int option=0;
      do{
      Console.WriteLine("Enter number for the Car company: ");
      Console.WriteLine("1.Indica\n2.Qualis\n3.MBenzE\n4.Davidharley");
      option = Convert.ToInt16(Console.ReadLine());
      }while(option<1 || option>4);
      switch(option){
        case 1:
          Console.WriteLine("You have choosen Indica\n");
          bool flag = false;
          foreach(var car in IndicaCars){
            flag |= car.checkInmaintainance();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < IndicaCars.Count;i++){
            var car = IndicaCars[i];
            if(!car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < IndicaCars.Count && IndicaCars[option].checkInmaintainance()){
            IndicaCars[option].getfrommaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 2:
          Console.WriteLine("You have choosen Qualis");
          flag = false;
          foreach(var car in QualisCars){
            flag |= car.checkInmaintainance();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < QualisCars.Count;i++){
            var car = QualisCars[i];
            if(!car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < QualisCars.Count && QualisCars[option].checkInmaintainance()){
            QualisCars[option].getfrommaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 3:
          Console.WriteLine("You have choosen MBenzE");
          flag = false;
          foreach(var car in MBenzEclassCars){
            flag |= car.checkInmaintainance();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < MBenzEclassCars.Count;i++){
            var car = MBenzEclassCars[i];
            if(!car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < MBenzEclassCars.Count && MBenzEclassCars[option].checkInmaintainance()){
            MBenzEclassCars[option].getfrommaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
        case 4:
          Console.WriteLine("You have choosen Davidharley");
          flag = false;
          foreach(var car in DavidharleyCars){
            flag |= car.checkInmaintainance();
          }
          if(!flag){
            Console.WriteLine("None of the car of this company is on Maintainance.");
            return;
          }
          Console.WriteLine("Choose one of the below unique id to select the car:=>");
          for(int i = 0;i < DavidharleyCars.Count;i++){
            var car = DavidharleyCars[i];
            if(!car.checkInmaintainance())continue;
            Console.WriteLine($"{i}.###############################");
            Console.WriteLine(car);
          }
          option = Convert.ToInt16(Console.ReadLine());
          if(option >= 0 && option < DavidharleyCars.Count && DavidharleyCars[option].checkInmaintainance()){
            DavidharleyCars[option].getfrommaintainance();
          }
          else{
            Console.WriteLine("Not a valid id");
          }
          break;
      }  
    }
    public static void GetCheckListRentedandAvailableVehicle(){
      Console.WriteLine("******INDICA******");
      foreach(var car in IndicaCars){
        if(car.checkRented())
          Console.WriteLine("Status: Rented");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
      Console.WriteLine("******QUALIS******");
      foreach(var car in QualisCars){
        if(car.checkRented())
          Console.WriteLine("Status: Rented");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
      Console.WriteLine("******MBENZ******");
      foreach(var car in MBenzEclassCars){
        if(car.checkRented())
          Console.WriteLine("Status: Rented");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
      Console.WriteLine("******DAVID HARLEY******");
      foreach(var car in DavidharleyCars){
        if(car.checkRented())
          Console.WriteLine("Status: Rented");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
    }

    //i have not made it because of the uncertainity of end date in our project
    // public static void ShowAvailabilityforbookingforgivendate(){
    // }

    public static void GetCheckListvehilcesinmaintainence(){
      Console.WriteLine("******INDICA******");
      foreach(var car in IndicaCars){
        if(car.checkInmaintainance())
          Console.WriteLine("Status: Under Maintainance");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
      Console.WriteLine("******QUALIS******");
      foreach(var car in QualisCars){
        if(car.checkInmaintainance())
          Console.WriteLine("Status: Under Maintainance");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
      Console.WriteLine("******MBENZ******");
      foreach(var car in MBenzEclassCars){
        if(car.checkInmaintainance())
          Console.WriteLine("Status: Under Maintainance");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
      Console.WriteLine("******DAVID HARLEY******");
      foreach(var car in DavidharleyCars){
        if(car.checkInmaintainance())
          Console.WriteLine("Status: Under Maintainance");
        else
          Console.WriteLine("Status: Available");
        Console.WriteLine(car);
      }
    }

  }
  class Test{
    public static void Main(){
      int option = 0;
      while((option = APIforcar.menu()) != 8){
        switch(option){
          case 1:
            APIforcar.addCar();
          break;
          case 2:
            APIforcar.giveForrent();
          break;
          case 3:
            APIforcar.returnCar();
          break;
          case 4:
            APIforcar.giveformaintainance();
          break;
          case 5:
            APIforcar.getfrommaintainance();
          break;
          case 6:
            APIforcar.GetCheckListRentedandAvailableVehicle();
          break;
          case 7:
            APIforcar.GetCheckListvehilcesinmaintainence();
          break;
        }
        Console.WriteLine("Press any key to continue....");
        Console.ReadKey();
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      }
      
    }
  }
}