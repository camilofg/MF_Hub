namespace Repository_Mf_Hub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mindfulness_v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.__EFMigrationsHistory",
                c => new
                    {
                        MigrationId = c.String(nullable: false, maxLength: 150),
                        ProductVersion = c.String(nullable: false, maxLength: 32),
                    })
                .PrimaryKey(t => t.MigrationId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        UserId = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                        PriorityId = c.Int(nullable: false),
                        Dateline = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CreationDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        SetAlarm = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
            CreateTable(
                "dbo.Priorities",
                c => new
                    {
                        PriorityId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        MaxTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PriorityId);
            
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ProfileId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProfileId);
            
            CreateTable(
                "dbo.Statuses",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PasswordHash = c.String(),
                        SecuritySalt = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        ProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Statuses");
            DropTable("dbo.Profiles");
            DropTable("dbo.Priorities");
            DropTable("dbo.Items");
            DropTable("dbo.__EFMigrationsHistory");
        }
    }
}
