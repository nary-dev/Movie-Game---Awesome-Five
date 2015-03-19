namespace MovieGame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmovielist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieModels");
        }
    }
}
