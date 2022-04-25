using System;

namespace numberguessgame
{
    public class program 
    {
        public static void Main(string[] args)
        {
            var random = new Random();
            bool playAgain= true;
            int min = 1, max = 100, guess, number,guesses;
            string response;

            while(playAgain)
            {
                guess = 0; 
                guesses = 0;
                number = random.Next(min, max+1);
            while(guess != number)
            {
                Console.Write($"Guess a number between {min}-{max}:");
                guess = int.Parse(Console.ReadLine());
                System.Console.WriteLine("Guess: "+guess);
                if(guess< number)
                {
                    System.Console.WriteLine("Higher please!");
                }
                else if(guess>number)
                {
                    System.Console.WriteLine("Lower please!");
                }
                guesses++; 
            }
                System.Console.WriteLine("You win!");
                System.Console.WriteLine($"The number is {number}");
                System.Console.WriteLine($"You guessed it correctly in {guesses} guesses");
                System.Console.WriteLine("Do you want to play again (Y/N): ");
                response = Console.ReadLine();
                String Response = response.ToUpper();
                if(Response == "Y")
                    {
                        playAgain = true;
                    }
                else if(Response == "N")
                    {
                        playAgain = false;
                    }
            }
            
        }
    }
}