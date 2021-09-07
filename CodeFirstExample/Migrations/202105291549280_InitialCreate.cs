namespace CodeFirstExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fakultelers",
                c => new
                    {
                        fakulteID = c.Int(nullable: false, identity: true),
                        fakulteAd = c.String(),
                    })
                .PrimaryKey(t => t.fakulteID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fakultelers");
        }
    }
}
