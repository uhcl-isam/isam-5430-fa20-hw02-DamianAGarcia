﻿using System;
using static System.Console;
namespace CSharp.Assignments.Loop1
{
    /// <summary>
    /// Drivers are concerned with the mileage their automobiles get.
    /// One driver has kept track of several tankfuls of gasoline by 
    /// recording the miles driven and gallons used for each tankful. 
    /// Develop a C# app that will input the miles driven and gallons
    /// used (both as integers) for each tankful. The app should calculate
    /// and display the miles per gallon obtained for each tankful and 
    /// display the combined miles per gallon obtained for all tankfuls
    /// up to this point. All averaging calculations should produce
    /// floating-point results. Display the miles per gallons on one line
    /// and the total miles per gallons on another, both rounded to the
    /// nearest hundredth, immediately after each input. Use the Console
    /// class’s ReadLine method and sentinel-controlled iteration
    /// (e.g. when miles driven are negative, the loop ends) to
    /// obtain the data from the user.
    /// </summary>
    public class GasMileage
    {
        public static void Main()
        {
            {
                float miles = 0;
                float gallons = 0;
                while (miles >= 0 && gallons >= 0)
                {
                    // prompt user for non-negative miles and obtain the input from user
                    Console.WriteLine("Please enter number of mile: ");
                    miles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter number of gallons: ");
                    gallons = Convert.ToInt32(Console.ReadLine());
                    if (miles >= 0 && gallons >= 0)
                    {
                        float mpg = miles / gallons;
                        Console.WriteLine("Your miles per gallons is " + mpg.ToString("0.00") + ".");
                    }
                    else
                    {
                        Console.WriteLine("You entered in an invalid number.");
                    }
                }
            }
        }
    }
}
