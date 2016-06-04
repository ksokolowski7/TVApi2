namespace TVApi.MigrationsApp
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTest2Entity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Test2Entity",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Test2Entity");
        }
    }
}
