namespace Repository_Mf_Hub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNavigationProperties : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Items", "UserId");
            CreateIndex("dbo.Items", "PriorityId");
            CreateIndex("dbo.Users", "ProfileId");
            AddForeignKey("dbo.Items", "PriorityId", "dbo.Priorities", "PriorityId", cascadeDelete: true);
            AddForeignKey("dbo.Users", "ProfileId", "dbo.Profiles", "ProfileId", cascadeDelete: true);
            AddForeignKey("dbo.Items", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "ProfileId", "dbo.Profiles");
            DropForeignKey("dbo.Items", "PriorityId", "dbo.Priorities");
            DropIndex("dbo.Users", new[] { "ProfileId" });
            DropIndex("dbo.Items", new[] { "PriorityId" });
            DropIndex("dbo.Items", new[] { "UserId" });
        }
    }
}
