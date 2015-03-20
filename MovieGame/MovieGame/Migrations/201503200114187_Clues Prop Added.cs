namespace MovieGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CluesPropAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieModels", "Clues", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MovieModels", "Clues");
        }
    }
}
