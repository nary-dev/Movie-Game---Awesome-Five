using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    class LogicModel
    {
        public void newMethod(MovieView view)
        {
            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                //TODO
                //give the clue  
            }
            else
            {
                 view.hitEnter();

            }
        }
    }
}
