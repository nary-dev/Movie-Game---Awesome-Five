using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    class MovieView
    {
        public Player player;

        public void WelcomeToPlayer(string method)
        {
            Console.WriteLine("Welcome to the game{0}", method);
        }

        public string WelcomeUser()
        {
            Console.WriteLine("!!WELCOME TO OUR GUESS THE MOVIE GAME!!");

            Console.WriteLine("Please enter your name??");
            
            string username = Console.ReadLine();
            player = new Player(username);

            return username;

        }


        public void Instuction()
        {
            Console.WriteLine("When you hit enter you get a clue about the movie");

            Console.WriteLine("Then write your Guess");

            Console.WriteLine("If you Guess is correct you get points");

            Console.WriteLine("if your Guess is not correct you Must try again");

            //clue could be for same movie or a new movie
            //Console.WriteLine("After 3 Chances you get a new clue");

            Console.WriteLine("Hit enter to continue");

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                //TODO
                //give the clue  
                Console.WriteLine("Lets get guessing");
            }
            else
            {
                Console.WriteLine("Please hit enter ");
            }

        }

        public void WriteClue(string clue)
        {
            Console.WriteLine(clue);
        }

<<<<<<< HEAD
        public void Correct()
        {
            Console.WriteLine("Congratulations! Someone needs to get outside more!");
            player.Score += 1;
        }
=======
        public void PrintClue(string passclue)
        {
            
         


        }


        public void TrueOrFalse()
        {
            
        }



        public void PrintScore()
        {
            


        }




>>>>>>> origin
    }
}
