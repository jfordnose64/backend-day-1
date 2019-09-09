using System;

namespace backend_day_1
{
  class Program
  {
    static void Main(string[] args)
    {
      var lower = 0m;
      var higher = 100m;
      var correctGuess = false;

      Console.WriteLine("Play Number Guesser?");
      var startInput = Console.ReadLine();
      if (startInput == "y")
      {
        correctGuess = false;
      }



      while (!correctGuess)
      {
        var guess = Math.Floor((lower + higher) / 2);
        Console.WriteLine($"Is your number {guess}?");
        var input = Console.ReadLine();
        if (input == "y")
        {
          correctGuess = true;
          Console.WriteLine("I Won! Try Again?");
          var winInput = Console.ReadLine();
          if (winInput == "y")
          {
            correctGuess = false;
            lower = 0m;
            higher = 100m;
          }
        }
        else if (input == "higher")
        {
          lower = guess;
        }
        else if (input == "lower")
        {
          higher = guess;
        }
      }
    }
  }
}
