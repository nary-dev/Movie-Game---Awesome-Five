using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieGame
{
    public class MovieModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Clues { get; set; }

        public bool Clue { get; set; }
       
        public MovieDBContext context = new MovieDBContext();

        public void Getclue()
        {
            context.Movies.Where(p => p.Clue);
        }
    }
}
