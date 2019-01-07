using System;

namespace randomNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      int secret;
      bool won = false;

      Console.WriteLine("Let's play the numbers game!");
      Random rand = new Random();
      secret = rand.Next(1, 101);
      Console.WriteLine(secret);
      while (!won) ;
      string guessString = Console.ReadLine();

      int guess;
      if (Int41.TryParse(guessString, out guess))
      {
        if (guess == secret)
        {
          Console.WriteLine("You Win!!!!");
          won = true;
        }
        else if (guess > secret)
        {
          Console.WriteLine("Guess is too high");
        }
        else
        {
          Console.WriteLine("Guess is too low");
        }
      }

    }
  }
}
