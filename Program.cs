using System;
using System.Collections.Generic;


namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool wordGuessed = false;
            int lettersGuessed = 0;
            //my bools aren't working FeelsWeakMan

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Well well well.. welcome to HANGMAN HARDCORE. You only get one shot. Ready to begin? I hope so.");

            Console.ForegroundColor = ConsoleColor.White;
            //words list
            string[] listwords = new string[6];
            listwords[0] = "bilberry";
            listwords[1] = "nuclear";
            listwords[2] = "beeswax";
            listwords[3] = "chestnut";
            listwords[4] = "honeycomb";
            listwords[5] = "marigold";
            //word selector
            Random randGen = new Random();
            var catalogue = randGen.Next(0, 5);
            string theWord = listwords[catalogue];
            char[] guess = new char[theWord.Length];

            //explain how to play + start game
            Console.Write("The hints are as follows: \n A type of goat\n A type of (slightly dangerous) energy/power \n Nunya \n Roasting on an open fire \n Something from bees you eat that isn't honey \n A type of flower that popularly symbolises death\n \n Your guess? \nOne letter at a time, of course.\n \n");
            Console.Write("Every word has an 'e' in it...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n...except one\n \n");
            Console.ForegroundColor = ConsoleColor.White;


            // X out the word!
            for (int x = 0; x < theWord.Length; x++)
                guess[x] = 'X';

            //gameplay
            while (true)
            {
                
                
                echar playerGuess = char.Parse(Console.ReadLine());
                for (int x = 0; x < theWord.Length; x++)
                {
                    if (playerGuess == theWord[x])
                        guess[x] = playerGuess;

                }
                Console.WriteLine(guess);
                lettersGuessed++;

               // if(guess.Equals(theWord.Length))
                if (lettersGuessed.Equals(theWord.Length))
                {
                    wordGuessed = true;

                    Console.ForegroundColor = ConsoleColor.Red;
              
                    Console.WriteLine("\nWelp there's your turns, hope you got it!\n\n\n");
                    //Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.ReadKey();
                    break;
                }
            }

        }
    }
}