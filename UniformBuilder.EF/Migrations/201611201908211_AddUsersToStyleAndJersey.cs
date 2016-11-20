namespace UniformBuilder.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersToStyleAndJersey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jerseys", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Jerseys", "LastUpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Jerseys", "Creator_Id", c => c.Guid());
            AddColumn("dbo.Jerseys", "LastUpdatedBy_Id", c => c.Guid());
            AddColumn("dbo.UniformStyles", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UniformStyles", "LastUpdateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.UniformStyles", "Creator_Id", c => c.Guid());
            AddColumn("dbo.UniformStyles", "LastUpdatedBy_Id", c => c.Guid());
            CreateIndex("dbo.Jerseys", "Creator_Id");
            CreateIndex("dbo.Jerseys", "LastUpdatedBy_Id");
            CreateIndex("dbo.UniformStyles", "Creator_Id");
            CreateIndex("dbo.UniformStyles", "LastUpdatedBy_Id");
            AddForeignKey("dbo.Jerseys", "Creator_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Jerseys", "LastUpdatedBy_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.UniformStyles", "Creator_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.UniformStyles", "LastUpdatedBy_Id", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UniformStyles", "LastUpdatedBy_Id", "dbo.Users");
            DropForeignKey("dbo.UniformStyles", "Creator_Id", "dbo.Users");
            DropForeignKey("dbo.Jerseys", "LastUpdatedBy_Id", "dbo.Users");
            DropForeignKey("dbo.Jerseys", "Creator_Id", "dbo.Users");
            DropIndex("dbo.UniformStyles", new[] { "LastUpdatedBy_Id" });
            DropIndex("dbo.UniformStyles", new[] { "Creator_Id" });
            DropIndex("dbo.Jerseys", new[] { "LastUpdatedBy_Id" });
            DropIndex("dbo.Jerseys", new[] { "Creator_Id" });
            DropColumn("dbo.UniformStyles", "LastUpdatedBy_Id");
            DropColumn("dbo.UniformStyles", "Creator_Id");
            DropColumn("dbo.UniformStyles", "LastUpdateDate");
            DropColumn("dbo.UniformStyles", "CreateDate");
            DropColumn("dbo.Jerseys", "LastUpdatedBy_Id");
            DropColumn("dbo.Jerseys", "Creator_Id");
            DropColumn("dbo.Jerseys", "LastUpdateDate");
            DropColumn("dbo.Jerseys", "CreateDate");
        }
    }
}
