namespace Repository_Mf_Hub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdMig : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Items", "StatusId");
            AddForeignKey("dbo.Items", "StatusId", "dbo.Statuses", "StatusId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "StatusId", "dbo.Statuses");
            DropIndex("dbo.Items", new[] { "StatusId" });
        }
    }
}
