using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    internal class Program
    {
        class TemperatureTracker
        {
            public double[] dailyTemperatures = new double[7];

            public void InputTemperatures()
            {
                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"Enter Temperature for Day {i+1}: ");

                    while (!double.TryParse(Console.ReadLine(), out dailyTemperatures[i]))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid temperature: ");
                    }
                }
            }

            public void DisplayTemperatureReport()
            {
                Console.WriteLine("\nWeekly Temperature Report: ");

                for (int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"Day {i+1}: {dailyTemperatures[i]}°C");
                }
            }
        }

        static void Main(string[] args)
        {
            TemperatureTracker weeklyTemperatures = new TemperatureTracker();

            weeklyTemperatures.InputTemperatures(); // Input the temperatures for the week
            weeklyTemperatures.DisplayTemperatureReport();  // Display the weekly temperature report

            Console.ReadLine();
        }
    }
}
