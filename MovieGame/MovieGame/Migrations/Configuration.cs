namespace MovieGame.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MovieGame.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MovieGame.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Movies.AddOrUpdate(
              p => p.Name,
            new MovieModel { Name = "Gladiator", Clues = "My name is Maximus, I fight other men in a big circle"},
            new MovieModel { Name = "Titanic", Clues = "I wont leave you Jack"},
            new MovieModel { Name = "Shrek", Clues = "That's right, fool! Now I'm a flying talking donkey! You might have seen a housefly, maybe even a superfly, but I bet you ain't never seen a donkeyfly! Ha, ha!"},
            new MovieModel { Name = "Toy Story", Clues = "A boy called Andy has a 6 inch toy called woody and a big shiny toy called Buzz who takes individuals to infinity and beyond" },
            new MovieModel { Name = "Anchor Man", Clues = "4 friends, 1 not so bright, 2 sports enthusiast, 3 ladies man, 4 the big cheese with good hair."},
            new MovieModel { Name = "Inception", Clues = "I had a dream within a dream..."},
            new MovieModel { Name = "American Beauty", Clues = "This will be the highpoint of my day, its all downhill from here" },
            new MovieModel { Name = "Pulp Fiction", Clues = "They call it a Royale with cheese."},
            new MovieModel { Name = "Shawshank Redemption", Clues = "He had a quiet way about him, a walk and a talk that just wasn't normal around here. He strolled, like a man in a park without a care or a worry in the world, like he had on an invisible coat that would shield him from this place. Yeah, I think it would be fair to say...I liked Andy from the start." },
            new MovieModel { Name = "Forrest Gump", Clues = "I may not be a smart man, but I know what love is." }
            );



        }
    }
}
