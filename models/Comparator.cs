using System;

namespace RPSLS.Models
{
   class Comparator
   {
      public String Compare(ConsoleKey userInput, int cpuMove)
      {
         String result = "Error";

         switch (userInput)
         {
            case ConsoleKey.R:

               switch (cpuMove)
               {
                  case 0:
                     result = "Rock is covered by Paper, you lose";
                     break;
                  case 1:
                     result = "Rock smashes Scissors, you win!";
                     break;
                  case 2:
                     result = "Draw";
                     break;
               }

               break;
            case ConsoleKey.P:

               switch (cpuMove)
               {
                  case 0:
                     result = "Draw";
                     break;
                  case 1:
                     result = "Paper is cut by Scissors, you lose";
                     break;
                  case 2:
                     result = "Paper covers rock, you win!";
                     break;
               }

               break;
            case ConsoleKey.S:

               switch (cpuMove)
               {
                  case 0:
                     result = "Scissors cuts Paper, you win!";
                     break;
                  case 1:
                     result = "Draw";
                     break;
                  case 2:
                     result = "Scissors are smashed by Rock, you lose";
                     break;
               }

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