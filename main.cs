// Cristiano
// ICS2O-Unit3-03-CSharp
// April 4 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        float radius;
        double answer;

        Console.WriteLine("Enter radius of sphere (cm):");
        radius = Convert.ToSingle(Console.ReadLine());
        answer = 1.33333333 * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine("\nThe volume of this sphere is " + (answer).ToString("0.00") + " cm³");
        Console.WriteLine("\nFinished.");
    }
}
