using System;

namespace FitnessFrog
{
    class Program
  {
      static void Main()
      {
        int runningTotal = 0;
          // Prompt user for minutes exercised 
          Console.Write("Enter how many minutes you exercised: ");
          int newEntry = int.Parse(Console.ReadLine());
          // Add minutes exercised to total 
          runningTotal = runningTotal + newEntry;
  
          
          // Display total minutes exercised to the screen 
          Console.WriteLine("You've entered " + runningTotal + " minutes");
          // Repeat until user quits    
      }
  }
}