using System;

namespace RPSLS.Models
{
   class Comparator
   {
      public String Compare(ConsoleKey userInput, String cpuMove)
      {
         String result = "";

         switch (userInput)
         {
            case ConsoleKey.R:
               result = "Rock is covered by Paper, you lose";
               break;
            case ConsoleKey.P:
               result = "Paper vs. Paper, draw";
               break;
            case ConsoleKey.S:
               result = "Scissors cuts Paper, you win!";
               break;
            case ConsoleKey.Q:
               result = "Quit";
               break;
            default:
               result = "InvalidInput";
               break;
         }

         return result;
      }
   }
}