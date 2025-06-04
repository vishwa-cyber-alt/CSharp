//Constructor
using System;
class Car {
  public string name;
  public string designation;
  public Car() {
    name = "vishwa";
    designation = "Software Developer";
  }

  public static void Main(string[] args) {
    Car a = new Car();
    Console.WriteLine("Name : " + a.name);
    Console.WriteLine("Designation : " + a.designation);
  }
}
