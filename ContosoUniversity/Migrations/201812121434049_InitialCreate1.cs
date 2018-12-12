namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        ArticleID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Text = c.String(),
                        Magazine_MagazineID = c.Int(),
                    })
                .PrimaryKey(t => t.ArticleID)
                .ForeignKey("dbo.Magazine", t => t.Magazine_MagazineID)
                .Index(t => t.Magazine_MagazineID);
            
            CreateTable(
                "dbo.Magazine",
                c => new
                    {
                        MagazineID = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 50),
                        Genre = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.MagazineID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article", "Magazine_MagazineID", "dbo.Magazine");
            DropIndex("dbo.Article", new[] { "Magazine_MagazineID" });
            DropTable("dbo.Magazine");
            DropTable("dbo.Article");
        }
    }
}
