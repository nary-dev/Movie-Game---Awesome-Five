using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    public class Router
    {
        MovieController controller = new MovieController();

        public void Route(string[] args)
        {
            var command = args.Length != 0 ? args[0].ToLowerInvariant() : String.Empty;
            controller.CheckGuess(command);
        }
    }
}
