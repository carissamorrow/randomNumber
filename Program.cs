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
      string guessString = Console.ReadLine();
      int guess;
      while (!won) ;

      if (Int32.TryParse(guessString, out guess))
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
      Console.WriteLine("Please Try Again");
    }
  }
}
