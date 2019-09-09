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

      while (!correctGuess)
      {
        var guess = Math.Floor((lower + higher) / 2);
        Console.WriteLine($"Is your number {guess}?");
        var input = Console.ReadLine();
        if (input == "y")
        {
          correctGuess = true;
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
