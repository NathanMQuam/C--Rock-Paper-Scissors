using System;
using System.Threading;
using RPSLS.Models;

namespace RPSLS
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.Clear();

         string[] options = new string[5]{
             "Rock",
             "Paper",
             "Scissors",
             "Lizard",
             "Spock"
         };

         bool running = true;
         while (running)
         {
            Cpu cpu = new Cpu();
            //  TODO: Prompt user for difficulty

            // Prompt the user for their input
            System.Console.WriteLine(@"What will you play? 
(R) Rock
(P) Paper
(S) Scissors
(Q) Quit
");

            ConsoleKeyInfo userInput = Console.ReadKey();
            System.Console.WriteLine();

            // Determine the AI's input
            int cpuMove = cpu.move();

            // Compare the results
            Comparator comparator = new Comparator();
            String result = comparator.Compare(userInput.Key, cpuMove);
            if (result != "Quit")
            {
               System.Console.WriteLine(result);
               Thread.Sleep(3000);
               Console.Clear();
            }
            else
            {
               running = false;
            }

         }
      }
   }
}
