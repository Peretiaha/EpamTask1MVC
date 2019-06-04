namespace StorageControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Voitings",
                c => new
                    {
                        VId = c.Int(nullable: false, identity: true),
                        Choice = c.String(),
                    })
                .PrimaryKey(t => t.VId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Voitings");
        }
    }
}
