using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    public class MovieController
    {
        MovieModel Model = new MovieModel();
        MovieView View = new MovieView();
        LogicModel logic = new LogicModel();

        private string input;


        public void start()
        {
            View.WelcomeUser();
            View.Instuction();
            logic.newMethod(View);
        }

        public void CheckGuess(string command)
        {
            //check the guess in model
            throw new NotImplementedException();
            //then show if guess is correct or not
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}
