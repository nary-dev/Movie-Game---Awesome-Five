using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    class MovieView
    {

        public void WelcomeUser()
        {
            Console.WriteLine("!!WELCOME TO OUR GUESS THE MOVIE GAME!!");

            Console.WriteLine("Please enter your name??");

            string username = Console.ReadLine();

            Console.WriteLine("Welcome to the game{0}", username);   
        }




    }
}
