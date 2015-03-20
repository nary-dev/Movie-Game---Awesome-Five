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

        public void Route()
        {
            controller.start();
        }
    }
}
