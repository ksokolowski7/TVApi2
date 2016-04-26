namespace TVApi.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FavouriteMovieEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FriendEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestEntity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FriendEntityFavouriteMovieEntity",
                c => new
                    {
                        FriendEntity_Id = c.Int(nullable: false),
                        FavouriteMovieEntity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FriendEntity_Id, t.FavouriteMovieEntity_Id })
                .ForeignKey("dbo.FriendEntity", t => t.FriendEntity_Id, cascadeDelete: true)
                .ForeignKey("dbo.FavouriteMovieEntity", t => t.FavouriteMovieEntity_Id, cascadeDelete: true)
                .Index(t => t.FriendEntity_Id)
                .Index(t => t.FavouriteMovieEntity_Id);
            
            CreateTable(
                "dbo.UserEntityFavouriteMovieEntity",
                c => new
                    {
                        UserEntity_Id = c.Int(nullable: false),
                        FavouriteMovieEntity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserEntity_Id, t.FavouriteMovieEntity_Id })
                .ForeignKey("dbo.UserEntity", t => t.UserEntity_Id, cascadeDelete: true)
                .ForeignKey("dbo.FavouriteMovieEntity", t => t.FavouriteMovieEntity_Id, cascadeDelete: true)
                .Index(t => t.UserEntity_Id)
                .Index(t => t.FavouriteMovieEntity_Id);
            
            CreateTable(
                "dbo.UserEntityFriendEntity",
                c => new
                    {
                        UserEntity_Id = c.Int(nullable: false),
                        FriendEntity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserEntity_Id, t.FriendEntity_Id })
                .ForeignKey("dbo.UserEntity", t => t.UserEntity_Id, cascadeDelete: true)
                .ForeignKey("dbo.FriendEntity", t => t.FriendEntity_Id, cascadeDelete: true)
                .Index(t => t.UserEntity_Id)
                .Index(t => t.FriendEntity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserEntityFriendEntity", "FriendEntity_Id", "dbo.FriendEntity");
            DropForeignKey("dbo.UserEntityFriendEntity", "UserEntity_Id", "dbo.UserEntity");
            DropForeignKey("dbo.UserEntityFavouriteMovieEntity", "FavouriteMovieEntity_Id", "dbo.FavouriteMovieEntity");
            DropForeignKey("dbo.UserEntityFavouriteMovieEntity", "UserEntity_Id", "dbo.UserEntity");
            DropForeignKey("dbo.FriendEntityFavouriteMovieEntity", "FavouriteMovieEntity_Id", "dbo.FavouriteMovieEntity");
            DropForeignKey("dbo.FriendEntityFavouriteMovieEntity", "FriendEntity_Id", "dbo.FriendEntity");
            DropIndex("dbo.UserEntityFriendEntity", new[] { "FriendEntity_Id" });
            DropIndex("dbo.UserEntityFriendEntity", new[] { "UserEntity_Id" });
            DropIndex("dbo.UserEntityFavouriteMovieEntity", new[] { "FavouriteMovieEntity_Id" });
            DropIndex("dbo.UserEntityFavouriteMovieEntity", new[] { "UserEntity_Id" });
            DropIndex("dbo.FriendEntityFavouriteMovieEntity", new[] { "FavouriteMovieEntity_Id" });
            DropIndex("dbo.FriendEntityFavouriteMovieEntity", new[] { "FriendEntity_Id" });
            DropTable("dbo.UserEntityFriendEntity");
            DropTable("dbo.UserEntityFavouriteMovieEntity");
            DropTable("dbo.FriendEntityFavouriteMovieEntity");
            DropTable("dbo.TestEntity");
            DropTable("dbo.UserEntity");
            DropTable("dbo.FriendEntity");
            DropTable("dbo.FavouriteMovieEntity");
        }
    }
}
