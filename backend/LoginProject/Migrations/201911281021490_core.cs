namespace LoginProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class core : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        userName = c.String(),
                        userPassword = c.String(),
                        userEmail = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
