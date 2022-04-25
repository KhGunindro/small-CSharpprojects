using System;

namespace RPS
{
    public class program
    {
        public static void Main(string[] args)
        {
            var random = new Random();//Instantiating a random object
            int min= 1, max = 3;
            bool playAgain = true;
            System.Console.WriteLine("Let's play rocks papers scissors!\n");

            while(playAgain)
            {
            System.Console.WriteLine("Enter your choice: \n");
            System.Console.Write("1.Rock 2.Paper 3.Scissors:");
            int mychoice = Convert.ToInt32(Console.ReadLine()); //Taking in user input
            if(mychoice == 1)
            {
                System.Console.WriteLine("\nYour choice : Rock");
            }
            else if(mychoice == 2)
            {
                System.Console.WriteLine("\nYour choice : Paper");
            }
            else if(mychoice == 3)
            {
                System.Console.WriteLine("\nYour choice : Scissors");
            }
            int compchoice = random.Next(min,max+1); //Making the computer choose a random number between 1-3
            if(compchoice == 1)
            {
                System.Console.WriteLine("computer's choice : Rock");
            }
            else if(compchoice == 2)
            {
                System.Console.WriteLine("computer's choice : Paper");
            }
            else if(compchoice == 3)
            {
                System.Console.WriteLine("Computer's choice : Scissors");
            }
            if(mychoice == 1 && compchoice ==2)
            {
                System.Console.WriteLine("\nComputer wins!");
            }
            else if(mychoice ==1 && compchoice ==3)
            {
                System.Console.WriteLine("\nyou win!");
            }
            else if(mychoice ==2 && compchoice ==1)
            {
                System.Console.WriteLine("\nyou win!");
            }
            else if(mychoice ==2 && compchoice ==3)
            {
                System.Console.WriteLine("\ncomputer wins!");
            }
            else if(mychoice ==3 && compchoice ==1)
            {
                System.Console.WriteLine("\ncomputer wins!");
            }
            else if(mychoice ==3 && compchoice ==2)
            {
                System.Console.WriteLine("\nyou win!");
            }
            else if(mychoice == compchoice)
            {
                System.Console.WriteLine("\nDraw!");
            }
            System.Console.Write("\nDo you want to play again(Y/N): ");
            string response = Console.ReadLine();
            string Response = response.ToUpper();
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