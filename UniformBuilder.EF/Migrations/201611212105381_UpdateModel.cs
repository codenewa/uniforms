namespace UniformBuilder.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Jerseys", "UniformStyle_Id", "dbo.UniformStyles");
            DropIndex("dbo.Jerseys", new[] { "UniformStyle_Id" });
            AddColumn("dbo.Jerseys", "UniformStyleId", c => c.Guid(nullable: false));
            DropColumn("dbo.Jerseys", "UniformStyle_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Jerseys", "UniformStyle_Id", c => c.Guid());
            DropColumn("dbo.Jerseys", "UniformStyleId");
            CreateIndex("dbo.Jerseys", "UniformStyle_Id");
            AddForeignKey("dbo.Jerseys", "UniformStyle_Id", "dbo.UniformStyles", "Id");
        }
    }
}
