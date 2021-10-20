using System;

class Program {
  public static double DetermineHypotenuse(double side1, double side2)
  {
    double Hyp = Math.Sqrt((side1*side1)+ (side2*side2));
    return Hyp;
  }
  public static void Main (string[] args) {
    Console.WriteLine("Please provide first side of triangle:");
    double side1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Please provide second side of triangle:");
    double side2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The hypotenuse for the triangle is: " + DetermineHypotenuse(side1, side2));
  }
}