using System;

namespace RPSLS.Models
{
   class Cpu
   {
      // public Cpu(String difficulty, String mode)
      // {
      //    Difficulty = difficulty;
      //    Mode = mode;
      // }

      public String Difficulty { get; set; }
      public String Mode { get; set; }

      public String move()
      {
         return "Paper";
      }
   }
}