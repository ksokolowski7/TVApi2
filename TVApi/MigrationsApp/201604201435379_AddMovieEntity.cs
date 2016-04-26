namespace TVApi.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MovieEntity");
        }
    }
}
