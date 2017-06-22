using System;

namespace FitnessFrog
{
    class Program
  {
      static void Main()
      {
        int runningTotal = 0;
        bool runFrog = true;

        while (runFrog)
        {
            // Prompt user for minutes exercised 
            Console.Write("Enter how many minutes you exercised, or type \"quit\" to exit: ");
            string newEntry = Console.ReadLine();
            
            // Repeat until user quits 
            if (newEntry == "quit")
            {
              runFrog = false;
            } 
            else
            {
              int newInt = int.Parse(newEntry);
              // Add minutes exercised to total 
              runningTotal = runningTotal + newInt;
      
              
              // Display total minutes exercised to the screen 
              Console.WriteLine("You've entered " + runningTotal + " minutes");  
            }
            
        } 
        Console.WriteLine("Goodbye");
      }
  }
}