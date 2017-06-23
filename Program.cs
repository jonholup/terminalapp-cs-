using System;

namespace FitnessFrog
{
    class Program
  {
      static void Main()
      {
        var runningTotal = 0.0;

        while (true)
        {
            // Prompt user for minutes exercised 
            Console.Write("Enter how many minutes you exercised, or type \"quit\" to exit: ");
            var newEntry = Console.ReadLine();

            // Repeat until user quits 
            if (newEntry.ToLower() == "quit")
            {
              break;
            } 
              try
              {
                var newInt = double.Parse(newEntry);
              if (newInt <= 0)
              {
                Console.WriteLine(newInt + " is not an acceptable number.");
                continue;
              }
              else if (newInt <= 15)
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

              // Add minutes exercised to total 
              runningTotal += newInt;

              // Display total minutes exercised to the screen 
              Console.WriteLine("You've entered " + runningTotal + " minutes");
              }
            catch (FormatException)
            {
              Console.WriteLine("That is not valid input.");
              continue;
            }
              // Print feedback dependent on newInt
            
        } 
        Console.WriteLine("Goodbye");
      }
  }
}