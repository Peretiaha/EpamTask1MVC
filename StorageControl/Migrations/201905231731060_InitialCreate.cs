namespace StorageControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        date = c.DateTime(nullable: false),
                        ArticleText = c.String(),
                    })
                .PrimaryKey(t => t.ArticleId);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        date = c.DateTime(nullable: false),
                        CommentText = c.String(),
                    })
                .PrimaryKey(t => t.CommentId);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profiles");
            DropTable("dbo.Comments");
            DropTable("dbo.Articles");
        }
    }
}
