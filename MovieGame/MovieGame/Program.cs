using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieController controller = new MovieController();
            controller.start();
            controller.Play();



            Console.ReadLine();

        }
    }
}
