namespace Repository_Mf_Hub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "StatusId", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Items", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.Items", "StatusId");
        }
    }
}
