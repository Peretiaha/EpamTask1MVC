namespace StorageControl.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogDB1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Tags", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "Tags");
        }
    }
}
