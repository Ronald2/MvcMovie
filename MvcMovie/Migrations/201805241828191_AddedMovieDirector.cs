namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMovieDirector : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Director", c => c.String(maxLength: 60));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Director");
        }
    }
}
