using System;
using System.Collections.Generic;

namespace Adventcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Advent of 2020!");

            int counter = 0;  
            string line;  
            List<string> passports = new List<string>();

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"..\adventcode\input\day4.txt");  
            while((line = file.ReadLine()) != null)  
            {  
                // System.Console.WriteLine(line);  
                counter++;  
                passports.Add(line);
            }  
            
            file.Close();  


            // Suspend the screen.  
            // System.Console.ReadLine();  
        }
    }
}
