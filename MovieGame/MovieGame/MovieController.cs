using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    public class MovieController
    {
        MovieModel Model = new MovieModel();
        MovieView View = new MovieView();
        LogicModel logic = new LogicModel();
        MovieDBContext context = new MovieDBContext();

        private string input;


        public void start()
        {
            //View.WelcomeUser();
            View.WelcomeToPlayer(View.WelcomeUser());
            View.Instuction();
            
            
        }

         public void GiveClue()
         {
            string guess = "";
            var database = context.Movies;

            foreach (var row in database)
            {


                while (guess != row.Name)
                {
                    Console.Clear();
                    View.WriteClue(row.Clues);
                    guess = Console.ReadLine();
                }

                View.Correct();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
