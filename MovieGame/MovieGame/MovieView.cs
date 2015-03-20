using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    public class MovieView
    {

        public void WelcomeUser()
        {
            Console.WriteLine("!!WELCOME TO OUR GUESS THE MOVIE GAME!!");

            Console.WriteLine("Please enter your name??");
            
            string username = Console.ReadLine();
            Player player = new Player(username);

            Console.WriteLine("Welcome to the game{0}", username);   
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
            }
            else
            {
                Console.WriteLine("Please hit enter ");
            }

        }




    }
}
