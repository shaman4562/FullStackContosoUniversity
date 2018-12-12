namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Article", "Magazine_MagazineID", "dbo.Magazine");
            DropIndex("dbo.Article", new[] { "Magazine_MagazineID" });
            RenameColumn(table: "dbo.Article", name: "Magazine_MagazineID", newName: "MagazineID");
            AlterColumn("dbo.Article", "MagazineID", c => c.Int(nullable: false));
            CreateIndex("dbo.Article", "MagazineID");
            AddForeignKey("dbo.Article", "MagazineID", "dbo.Magazine", "MagazineID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Article", "MagazineID", "dbo.Magazine");
            DropIndex("dbo.Article", new[] { "MagazineID" });
            AlterColumn("dbo.Article", "MagazineID", c => c.Int());
            RenameColumn(table: "dbo.Article", name: "MagazineID", newName: "Magazine_MagazineID");
            CreateIndex("dbo.Article", "Magazine_MagazineID");
            AddForeignKey("dbo.Article", "Magazine_MagazineID", "dbo.Magazine", "MagazineID");
        }
    }
}
