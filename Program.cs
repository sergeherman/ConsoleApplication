﻿using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {   
            double width, height, woodLength, glassArea;
            string name, country, widthString, heightString;

            name = "Siarhei Herman";
            country = "Belarus";

            Console.WriteLine($"\nMy name is {name}!");
            Console.WriteLine($"\nI am from {country}!");

            DateTime today = DateTime.Today;
            
            Console.WriteLine($"\nToday {today}!");

            int dayOfYear = today.DayOfYear;
            int dayChristmas = 358 - dayOfYear;

            Console.Write("Day of year: ");
            Console.WriteLine(dayOfYear);

            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}
