using System;

namespace RPSLS.Models
{
   class Cpu
   {
      // public Cpu(String difficulty, String mode)
      // {
      //    Difficulty = difficulty;
      // }

      public String Difficulty { get; set; }

      public int move()
      {
         Random r = new Random();
         int choice = r.Next(0, 3);
         return choice;
      }
   }
}