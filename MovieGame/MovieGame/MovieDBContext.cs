namespace MovieGame
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext()
            : base("name=MovieDBContext")
        {
        }

        public virtual DbSet<MovieModel> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {



        }
    }
}
