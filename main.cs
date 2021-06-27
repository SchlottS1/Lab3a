using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");
    double celsius = Convert.ToDouble(Console.ReadLine());
    double fahrenheit = celsius * 1.8 + 32;
    Console.WriteLine("The Fahrenheit equivalent for " + celsius + " degree celsius is " + fahrenheit);
    if (fahrenheit < 32) 
    {
      Console.WriteLine("This temperature is below the freezing temperature of 32 degrees fahrenheit.");
    }
    else if (fahrenheit > 212)
    {
      Console.WriteLine("This temperature is above the boiling point of 212 degrees fahrenheit.");
    }
  }
}