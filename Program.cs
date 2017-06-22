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
      
              // Print feedback dependent on newInt
              if (newInt <= 15)
              {
                Console.WriteLine("I like your style!");
              }
              else if (newInt <= 30)
              {
                Console.WriteLine("Way to go!");
              }
              else if (newInt <= 60)
              {
                Console.WriteLine("Ooof!");
              }
              else if (newInt >= 61)
              {
                Console.WriteLine("Insanity!");
              }
              else
              {
                Console.WriteLine("Does not compute");
              }

              // Display total minutes exercised to the screen 
              Console.WriteLine("You've entered " + runningTotal + " minutes");

            }
            
        } 
        Console.WriteLine("Goodbye");
      }
  }
}