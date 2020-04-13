using System;

//Namespace
namespace NameGuesser
{
    //Main Class
    class Program
    {
        // Entry Point Method   
        static void Main(string[] args)
        { 
            getAppInfo();
            playGame();
        }

        //Print color message
        static void ColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Print msg
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }

        static void getAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Trung Phan";

            //Write out App info
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
            
            //Ask users name
            Console.Write("What's your name?: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game!", userName);
        }

        static void playGame()
        {
            //Set correct number
            Random random = new Random();
            int correctNumber = random.Next(1, 11);

            //Init guess var
            int guessNumber = 0;

            Console.Write("Guess a number between 1 and 10: ");
            while (guessNumber != correctNumber)
            {
                string input = Console.ReadLine();
                //Check to be a number
                if (!int.TryParse(input, out guessNumber))
                {
                    //Console.ForegroundColor = ConsoleColor.Red;
                    //Console.WriteLine("Input number only!");
                    //Console.ResetColor();
                    ColorMessage(ConsoleColor.Red, "Input number only!");
                    //Kepp going
                    continue;
                }

                //Convert to number
                guessNumber = Int32.Parse(input);
                if (guessNumber != correctNumber)
                {
                    //Return false and guess again
                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Console.WriteLine("Wrong number, guess again!");
                        //Console.ResetColor();
                    ColorMessage(ConsoleColor.Red, "Wrong number, guess again!");
                }
            }

            //Return true
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Correct!\n");
            //Console.ResetColor();
            ColorMessage(ConsoleColor.Green, "Correct!\n");

            //Ask if play again
            Console.Write("Wanna play again?(Y/N): ");
            string state = Console.ReadLine().ToUpper();

            if (state == "Y")
                playGame();
            else
                return;
        }
    }
}
