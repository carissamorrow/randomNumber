using System;

namespace randomNumber
{
  class Program
  {
    static void Main(string[] args)
    {


      Console.WriteLine("Let's play the numbers game!");
      int secret;
      Random rand = new Random();
      secret = rand.Next(1, 101);
      Console.WriteLine(secret);
      bool won = true;
      while (!won) ;
      string guessString = Console.ReadLine();

      int guess;

      if (Int32.TryParse(guessString, out guess))
      {
        if (guess == secret)
        {
          Console.WriteLine("You Win!!!!");
          Console.WriteLine("Play again? (y/n)");
          string play = Console.ReadLine();
          if (play.ToLower() != "y")
          {
            won = false;
          }
          else
          {
            secret = rand.Next(1, 101);
            Console.WriteLine("I have a new number take a guess");
          }
          won = true;
        }
        else if (guess > secret)
        {
          Console.WriteLine("Guess is too high, try again:");
        }
        else
        {
          Console.WriteLine("Guess is too low, try again:");
        }
      }
    }
  }
}
