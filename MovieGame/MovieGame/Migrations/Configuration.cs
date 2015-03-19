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
            new MovieModel { Name = "Gladiator" },
            new MovieModel { Name = "Titanic" },
            new MovieModel { Name = "Shrek" },
            new MovieModel { Name = "Toy Story" },
            new MovieModel { Name = "Anchor Man" },
            new MovieModel { Name = "Inception" },
            new MovieModel { Name = "American Beauty" },
            new MovieModel { Name = "Pulp Fiction" },
            new MovieModel { Name = "Shawshank Redemption" },
            new MovieModel { Name = "Forrest Gump" }
            );

        }
    }
}
