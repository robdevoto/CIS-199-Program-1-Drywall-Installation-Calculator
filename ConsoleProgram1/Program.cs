// Program 1 Console
// CIS 199-03
// Due by: 2/15/2022
//Written by: S2210

// This program calculates the materials, labor, and costs required
// to build a shed based on user input.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variables and constants
            double frontLength;               // length of front wall
            double sideLength;                // length of side wall
            double height;                    // height of shed
            double costMaterialPerSqFt;       // material cost per square foot
            double costLaborPerSqFt;          // labor cost per square foot
            double totalSqFt;                 // total square feet for material
            double totalSqFt10;               // total square feet plus 10% extra for material
            double totalLaborCost;            // total labor cost
            double totalMaterialCost;         // total material cost
            double windowCost;                // cost of the window if added
            double totalCost;                 // total overall cost
            int windowNum;                    // optional installation of window
            const double WINDOW_FEE = 100;    // window fee constant 
            const double EXTRA_FACTOR = 1.1;  // extra 10% of material
            

            // Gather user input and convert to double
            WriteLine("Welcome to the Dry Wall and Window Installation Calculator\n");
            Write("Enter the length of the front (in feet): ");
            frontLength = double.Parse(ReadLine());

            Write("Enter the length of the side (in feet): ");
            sideLength = double.Parse(ReadLine());

            Write("Enter the height (in feet): ");
            height = double.Parse(ReadLine());

            Write("Enter 1 if you want a window, enter 0 if you do not: ");
            windowNum = int.Parse(ReadLine());

            Write("Enter cost of Dry Wall per square foot: ");
            costMaterialPerSqFt = double.Parse(ReadLine());

            Write("Enter cost of labor per square foot: ");
            costLaborPerSqFt = double.Parse(ReadLine());


            // Calculate individual and total square footage and cost amounts 
            totalSqFt = (frontLength * height * 2) + (sideLength * height * 2) + frontLength * sideLength;
            totalSqFt10 = totalSqFt * EXTRA_FACTOR;
            totalLaborCost = costLaborPerSqFt * totalSqFt10;
            totalMaterialCost = costMaterialPerSqFt * totalSqFt10;
            windowCost = WINDOW_FEE * windowNum;
            totalCost = windowCost + totalLaborCost + totalMaterialCost;
            

            // Display individual and total square footage and cost amounts 
            WriteLine($"\nTotal SQ feet needed: {totalSqFt:n}");
            WriteLine($"10% Extra Square feet: {totalSqFt10:n}");
            WriteLine($"Labor Cost: {totalLaborCost:C}");
            WriteLine($"Material Cost: {totalMaterialCost:C}");
            WriteLine($"Total Cost: {totalCost:C}");

        }
    }
}
